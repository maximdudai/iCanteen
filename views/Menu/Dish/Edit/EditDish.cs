using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;

namespace PSI_DA_PL_B.views.Menu.Dish.Edit
{
    public partial class EditDish : Form
    {
        Manager manager { get; set; }

        private int itemId { get; set; }

        private string type { get; set; }
        private string description { get; set; }
        private bool active { get; set; }

        public EditDish(int itemId, Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
            this.itemId = itemId;

            this.GetDishFromDatabase();
        }


        private void GetDishFromDatabase()
        {
            using (var db = new Cantina())
            {
                var dish = db.Dish.Find(this.itemId);

                this.description = dish.Description;
                this.type = dish.Type;
                this.active = dish.Active;
            }
            this.UpdateDishUI();
        }

        private void UpdateDishUI()
        {
            this.dishDescription.Text = this.description;
            
            // set dishType checkbox to the value from the database
            for(int i = 0; i < this.dishType.Items.Count; i++)
            {
                if (this.dishType.Items[i].ToString() == this.type)
                {
                    this.dishType.SelectedIndex = i;
                    dishType.SetItemChecked(i, true);
                    break;
                }
            }

            // set dishActive checkbox to the value from the database
            int index = this.active ? 0 : 1;

            this.dishActive.SelectedIndex = index;
            dishActive.SetItemChecked(index, true);
        }

        private void finishDishEdit_Click(object sender, EventArgs e)
        {
            this.UpdateDishData();
        }

        private void UpdateDishData()
        {
            using (var db = new Cantina())
            {
                var dish = db.Dish.Find(itemId);
                if(dish == null)
                {
                    MessageBox.Show("Prato não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dish.Description = this.description;
                dish.Type = this.type;
                dish.Active = this.active;

                db.SaveChanges();
            }

            this.manager.ShowDishListUI();
        }

        private void EditDish_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ShowDishListUI();
        }

        private void dishActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent selecting more than one item
            for (int i = 0; i < this.dishActive.Items.Count; i++)
            {
                if (i != this.dishActive.SelectedIndex)
                {
                    this.dishActive.SetItemChecked(i, false);
                }
            }
            this.active = this.dishActive.SelectedIndex == 0;
        }

        private void dishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent selecting more than one item

            for (int i = 0; i < this.dishType.Items.Count; i++)
            {
                if (i != this.dishType.SelectedIndex)
                {
                    this.dishType.SetItemChecked(i, false);
                }
            }
            this.type = this.dishType.SelectedItem.ToString();
        }

        private void dishDescription_TextChanged(object sender, EventArgs e)
        {
            this.description = this.dishDescription.Text;
        }
    }
}
