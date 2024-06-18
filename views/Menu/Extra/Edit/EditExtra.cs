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

namespace PSI_DA_PL_B.views.Menu.Extra.Edit
{
    public partial class EditExtra : Form
    {
        Manager manager { get; set; }

        private int itemId { get; set; }

        private decimal price { get; set; }
        private string description { get; set; }
        private bool active { get; set; }

        public EditExtra(int itemId, Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
            this.itemId = itemId;

            this.GetExtraFromDatabase();
        }

        private void GetExtraFromDatabase()
        {
            using (var db = new Cantina())
            {
                var extra = db.Extra.Find(this.itemId);

                this.description = extra.Descricao;
                this.price = extra.Preco;
                this.active = extra.Ativo;
            }
            this.UpdateExtraUI();
        }

        private void UpdateExtraUI()
        {
            this.extraDescription.Text = this.description;

            this.extraPrice.Text = $"Valor atual: {this.extraPrice}€";

            // set extraActive checkbox to the value from the database
            int index = this.active ? 0 : 1;

            this.extraActive.SelectedIndex = index;
            extraActive.SetItemChecked(index, true);
        }

        private void finishExtraEdit_Click(object sender, EventArgs e)
        {
            this.UpdateExtraData();
        }

        private void UpdateExtraData()
        {
            using (var db = new Cantina())
            {
                var extra = db.Extra.Find(itemId);
                if (extra == null)
                {
                    Error.Err("Extra não encontrado");
                    return;
                }

                extra.Descricao = this.description;
                extra.Preco = this.price;
                extra.Ativo = this.active;

                db.SaveChanges();
            }

            this.manager.ShowExtraListUI();
        }

        private void EditExtra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.manager.ShowExtraListUI();
        }

        private void extraActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent selecting more than one item
            for (int i = 0; i < this.extraActive.Items.Count; i++)
            {
                if (i != this.extraActive.SelectedIndex)
                {
                    this.extraActive.SetItemChecked(i, false);
                }
            }
            this.active = this.extraActive.SelectedIndex == 0;
        }

        private void extraPrice_TextChanged(object sender, EventArgs e)
        {
            this.price = decimal.Parse(this.extraPrice.Text);
        }

        private void extraDescription_TextChanged(object sender, EventArgs e)
        {
            this.description = this.extraDescription.Text;
        }
    }
}
