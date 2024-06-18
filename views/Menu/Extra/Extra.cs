using PSI_DA_PL_B.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Menu
{
    public partial class Extra : Form
    {
        Manager manager { get; set; }

        private List<models.Menu.Extra> extraList = new List<models.Menu.Extra>();
        public Extra()
        {
            InitializeComponent();

            this.manager = manager;
            this.LoadExtraFromDatabase();
        }


        private void dishCreate_Click(object sender, EventArgs e)
        {
            this.manager.ShowCreateDishUI();
        }



        private void LoadDishFromDatabase()
        {
            using (var db = new Cantina())
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

        private void HandleSelectExtra(object sender, EventArgs e)
        {
            //select from database dish where itemId = dishListBox.SelectedItem

            using (var db = new Cantina())
            {
                var dish = db.Dish.Find(extraListBox.SelectedItem);

                if (dish == null)
                {
                    MessageBox.Show("Extra not found");
                    return;
                }

                string extraPrice = this.extraPrice.Text;
                string extraActive = this.extraActive.Text;
                string extraDescription = this.extraDescription.Text;

                extraPrice.Text = extra.ExtraPrice;
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
