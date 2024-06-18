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

namespace PSI_DA_PL_B.views.Menu.Dish.Create
{
    public partial class CreateDish : Form
    {
        Manager manager { get; set; }
        private string description { get; set; }
        private string type { get; set; }
        private bool active { get; set; }

        public CreateDish(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
        }

        private void createDishButton_Click(object sender, EventArgs e)
        {
            this.description = this.dishDescription.Text;
            this.type = this.dishType.SelectedItem.ToString();
            
            if(this.dishActive.SelectedIndex == -1)
            {
                Error.Err("Please select if the dish will be available or not.");
                return;
            }
            this.active = this.dishActive.GetItemChecked(dishActive.SelectedIndex);

            if (String.IsNullOrEmpty(this.description) || String.IsNullOrEmpty(this.type) || this.active == false)
            {
                Error.Err("Please fill all fields");
                return;
            }

            using (var db = new Cantina())
            {
                db.Dish.Add(new models.Menu.Dish
                {
                    Description = this.description,
                    Type = this.type,
                    Active = this.active
                });

                db.SaveChanges();
            }
            this.manager.ShowDishListUI();
        }

        private void dishType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //prevent selecting more than one item
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < dishType.Items.Count; ++ix)
                {
                    if (e.Index != ix)
                    {
                        dishType.SetItemChecked(ix, false);
                    }
                }
            }

        }

        private void dishActive_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //prevent selecting more than one item
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < dishActive.Items.Count; ++ix)
                {
                    if (e.Index != ix)
                    {
                        dishActive.SetItemChecked(ix, false);
                    }
                }
            }
        }

        private void CreateDish_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ShowDishListUI();
        }
    }
}
