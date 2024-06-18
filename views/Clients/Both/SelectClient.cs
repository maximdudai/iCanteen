using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSI_DA_PL_B.views.Clients.Both.ListClients;

namespace PSI_DA_PL_B.views.Clients.Both
{
    public partial class SelectClient : Form
    {
        private Manager manager { get; set; }

        private int clientNifInput;

        private string menu;

        public SelectClient()
        {
            InitializeComponent();
        }
        public SelectClient(string menu,Manager manager) : this()
        {
            this.menu = menu;
            this.manager = manager;
        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientNifInput = int.Parse(searchClientNif.Text);

                if (!StudentRadioButton.Checked && !TeacherRadioButton.Checked)
                {
                    Error.Err("Not selected the type of client!");
                    return;
                }

                if (!Validator.IsValidClientNifSearch(this.clientNifInput))
                {
                    return;
                }

                using (var db = new Cantina())
                {
                    if (StudentRadioButton.Checked)
                    {
                        var students = db.User
                            .OfType<Student>()
                            .Where(u => u.Nif == this.clientNifInput)
                            .ToList();

                        if (students.Any())
                        {
                            MessageBox.Show("Client selected successfully!");
                            SourceButtonName(students.First().Nif);
                        }
                        else
                        {
                            Error.Err("Student not found!");
                            return;
                        }
                    }

                    if (TeacherRadioButton.Checked)
                    {
                        var teachers = db.User
                                .OfType<Teacher>()
                                .Where(u => u.Nif == this.clientNifInput)
                                .ToList();

                        if (teachers.Any())
                        {
                            MessageBox.Show("Client selected successfully!");
                            SourceButtonName(teachers.First().Nif);
                        }
                        else
                        {
                            Error.Err("Teacher not found!");
                            return;
                        }
                    }                    
                }
            }
            catch (FormatException)
            {
                Error.Err("NIF must be a number!");
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void SourceButtonName( int nif)
        {
            if (this.menu == "balance")
            {
                this.manager.BalanceUI(nif);
            }
            
            /*
            else if (this.menu == "reserva")
            {
                this.manager.ReservaUI(nif);
            }
            */
        }

        private void SelectClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }        
    }
}
