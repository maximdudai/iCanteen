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
using PSI_DA_PL_B.views.Menu.Dish.Create;

namespace PSI_DA_PL_B.views.Menu.Dish
{
    public partial class Dish : Form
    {
        Manager manager { get; set; }

        private List<models.Menu.Dish> dishList = new List<models.Menu.Dish>();
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

        private void Dish_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }

        private void HandleSelectDish(object sender, EventArgs e)
        {
            //select from database dish where itemId = dishListBox.SelectedItem

            using (var db = new Cantina())
            {
                var dish = db.Dish.Find(dishListBox.SelectedItem);

                if (dish == null)
                {
                    MessageBox.Show("Dish not found");
                    return;
                }

                string dishType = this.dishType.Text;
                string dishActive = this.dishActive.Text;
                string dishDescription = this.dishDescription.Text;
            }
        }
        private void UpdateDishUI()
        {

        }
        private void dishEdit_Click(object sender, EventArgs e)
        {

        }

        private void dishRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
