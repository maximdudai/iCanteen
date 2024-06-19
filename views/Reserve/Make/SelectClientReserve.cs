using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Reserve.Make
{
    public partial class SelectClientReserve : Form
    {
        private Manager manager { get; set; }
        private int clientNifInput;

        public SelectClientReserve()
        {
            InitializeComponent();
        }

        public SelectClientReserve(Manager manager) : this()
        {
            this.manager = manager;
        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            try
            {

                if (!StudentRadioButton.Checked && !TeacherRadioButton.Checked)
                {
                    Error.Err("Not selected the type of client!");
                    return;
                }

                this.clientNifInput = int.Parse(searchClientNif.Text);

                if (!Validator.IsValidClientNifSearch(this.clientNifInput))
                {
                    return;
                }

                using(var db = new Cantina())
                {
                    //of type != emplyee

                    var isClient = db.User
                        .Where(user => !(user is Employee))
                        .Where(c => c.Nif == this.clientNifInput)
                        .FirstOrDefault();

                    if (isClient == null)
                    {
                        Error.Err("Client not found!");
                        return;
                    }
                }
                this.manager.MakeReserveUI(clientNifInput, !TeacherRadioButton.Checked ? "Estudante" : "Professor");
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }


        private void SelectClientReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }        
    }
}
