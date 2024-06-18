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
        private double price { get; set; }
        private bool active { get; set; }

        public CreateExtra(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
        }

        private void createExtraButton_Click(object sender, EventArgs e)
        {
            this.description = this.extraDescription.Text;

            if (!double.TryParse(this.extraPrice.Text, out double extraPrice))
            {
                Error.Err("Please enter a valid number for the Price value.");
                return;
            }

            this.price = extraPrice;

            if (this.extraActive.SelectedIndex == -1)
            {
                Error.Err("Please select if the dish will be available or not.");
                return;
            }
            this.active = this.extraActive.GetItemChecked(extraActive.SelectedIndex);

            if (String.IsNullOrEmpty(this.description) || this.price <= 0 || this.active == false)
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
