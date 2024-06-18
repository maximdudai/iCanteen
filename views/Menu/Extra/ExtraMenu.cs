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

namespace PSI_DA_PL_B.views.Menu
{
    public partial class ExtraMenu : Form
    {
        Manager manager { get; set; }

        private List<models.Menu.Extra> extraList = new List<models.Menu.Extra>();

        private string description { get; set; }
        private decimal price { get; set; }
        private bool active { get; set; }
        public ExtraMenu(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
            this.LoadExtraFromDatabase();
        }

        private void LoadExtraFromDatabase()
        {
            using (var db = new Cantina())
            {
                extraList = db.Extra.ToList();
            }
            this.UpdateExtraList();
        }

        private void UpdateExtraList()
        {
            extraListBox.DataSource = null;
            extraListBox.DataSource = extraList;
        }

        
        private void UpdateExtraUI()
        {
            this.extraPrice.Text = this.price.ToString() + "€";
            this.extraActive.Text = this.active ? "Sim" : "Não";
            this.extraDescription.Text = this.description;
        }
        

        private void Extra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.manager.MainMenuUI();
        }

        private void extraRemove_Click(object sender, EventArgs e)
        {
            var selectedExtra = extraListBox.SelectedItem as models.Menu.Extra;

            if (selectedExtra == null)
            {
                Error.Err("Please select a extra to remove");
                return;
            }

            using (var db = new Cantina())
            {
                // Verify if the selected dish exists in the database using the itemId
                var extra = db.Extra.Find(selectedExtra.itemId);

                if (extra == null)
                {
                    Error.Err("The selected extra was not found in the database");
                    return;
                }

                db.Extra.Remove(extra);
                db.SaveChanges();

            }
            extraList.Remove(selectedExtra);

            if (extraListBox.Items.Count > 0)
                extraListBox.SetSelected(0, true);
            else
            {
                extraListBox.ClearSelected();
                this.extraPrice.Text = "-";
                this.extraActive.Text = "-";
                this.extraDescription.Text = "-";
            }

            this.UpdateExtraList();
        }

        private void editEdit_Click(object sender, EventArgs e)
        {
            var extra = extraListBox.SelectedItem as models.Menu.Extra;

            if (extra == null)
            {
                Error.Warning("Please select a extra to edit");
                return;
            }
            this.manager.ShowEditExtraUI(extra.itemId);
        }

        private void extraCreate_Click(object sender, EventArgs e)
        {
            this.manager.ShowCreateExtraUI();
        }

        private void extraListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select from database extra where itemId = extraListBox.SelectedItem

            using (var db = new Cantina())
            {
                var selectedExtra = extraListBox.SelectedItem as models.Menu.Extra;
                if (selectedExtra == null)
                    return;

                var extra = db.Extra.FirstOrDefault(d => d.itemId == selectedExtra.itemId);
                if (extra == null)
                    return;

                this.price = extra.Preco;
                this.active = extra.Ativo;
                this.description = extra.Descricao;

                this.UpdateExtraUI();
            }
        }
        private void createReservation_Click(object sender, EventArgs e)
        {

        }

    }
}
