using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.views.Menu.Dish.Create;

namespace PSI_DA_PL_B.views.Menu.Dish
{
    public partial class Dish : Form
    {
        Manager manager { get; set; }

        private List<models.Menu.Dish> dishList = new List<models.Menu.Dish>();

        private string description { get; set; }
        private string type { get; set; }
        private bool active { get; set; }

        public Dish(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
            this.LoadDishFromDatabase();
        }

        private void dishCreate_Click(object sender, EventArgs e)
        {
            this.manager.ShowCreateDishUI();
        }

        private void LoadDishFromDatabase()
        {
            using(var db = new Cantina())
            {
               dishList = db.Dish.ToList();
            }
            this.UpdateDishList();
        }

        private void UpdateDishList()
        {
            dishListBox.DataSource = null;
            dishListBox.DataSource = dishList;
        }

        private void HandleSelectDish(object sender, EventArgs e)
        {
            //select from database dish where itemId = dishListBox.SelectedItem

            using (var db = new Cantina())
            {
                var selectedDish = dishListBox.SelectedItem as models.Menu.Dish;
                if (selectedDish == null)
                    return;

                var dish = db.Dish.FirstOrDefault(d => d.itemId == selectedDish.itemId);
                if (dish == null)
                    return;

                this.type = dish.Type;
                this.active = dish.Active;
                this.description = dish.Description;

                this.UpdateDishUI();
            }
        }
        private void UpdateDishUI()
        {
            this.dishType.Text = this.type;
            this.dishActive.Text = this.active ? "Sim" : "Não";
            this.dishDescription.Text = this.description;
        }
        private void dishEdit_Click(object sender, EventArgs e)
        {
            var dish = dishListBox.SelectedItem as models.Menu.Dish;

            if (dish == null)
            {
                MessageBox.Show("Please select a dish to edit");
                return;
            }
            this.manager.ShowEditDishUI(dish.itemId);
        }

        private void dishRemove_Click(object sender, EventArgs e)
        {
            var selectedDish = dishListBox.SelectedItem as models.Menu.Dish;

            if (selectedDish == null)
            {
                Error.Err("Please select a dish to remove");
                return;
            }

            using (var db = new Cantina())
            {
                // Verify if the selected dish exists in the database using the itemId
                var dish = db.Dish.Find(selectedDish.itemId);

                if (dish == null)
                {
                    Error.Err("The selected dish was not found in the database");
                    return;
                }

                db.Dish.Remove(dish);
                db.SaveChanges();

            }
            dishList.Remove(selectedDish);

            if(dishListBox.Items.Count > 0)
                dishListBox.SetSelected(0, true);
            else
            {
                dishListBox.ClearSelected();
                this.dishType.Text = "-";
                this.dishActive.Text = "-";
                this.dishDescription.Text = "-";
            }

            this.UpdateDishList();
        }

        private void Dish_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }
    }
}
