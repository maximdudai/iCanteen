using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Menu.Extra.Create
{
    public partial class CreateExtra : Form
    {
        Manager manager { get; set; }
        private string description { get; set; }
        private decimal price { get; set; }
        private bool active { get; set; }

        public CreateExtra(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
        }

        private void createExtraButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(this.extraPrice.Text, out decimal extraPrice))
            {
                Error.Err("Please enter a valid number for the Price value.");
                return;
            }

            this.description = this.extraDescription.Text;
            this.price = extraPrice;
            this.active = this.extraActive.SelectedIndex == 0;


            // verify if at least one dishActive is checked
            if (this.extraActive.CheckedItems.Count == 0)
            {
                Error.Err("Please select if the dish will be available or not.");
                return;
            }

            if (string.IsNullOrEmpty(this.description) || this.price <= 0)
            {
                Error.Err("Please fill all fields");
                return;
            }

            using (var db = new Cantina())
            {
                db.Extra.Add(new models.Menu.Extra
                {
                    Descricao = this.description,
                    Preco = this.price,
                    Ativo = this.active
                });

                db.SaveChanges();
            }
            this.manager.ShowExtraListUI();
        }

        private void extraActive_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            //prevent selecting more than one item
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < extraActive.Items.Count; ++ix)
                {
                    if (e.Index != ix)
                    {
                        extraActive.SetItemChecked(ix, false);
                    }
                }
            }
        }
        private void CreateExtra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.manager.ShowExtraListUI();
        }
    }
}
