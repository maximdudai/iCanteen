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

        private string clientNifInput;

        public SelectClient()
        {
            InitializeComponent();
        }
        public SelectClient(Manager manager) : this()
        {
            this.manager = manager;
        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientNifInput = searchClientNif.Text;

                if (!StudentRadioButton.Checked && !TeacherRadioButton.Checked)
                {
                    Error.Err("Not selected the type of client!");
                    return;
                }

                if (Validator.IsValidClientNifSearch((this.clientNifInput)))
                {
                    return;
                }

                var parsedNif = int.Parse(this.clientNifInput);

                using (var db = new Cantina())
                {
                    if (StudentRadioButton.Checked)
                    {
                        var students = db.User
                            .OfType<Student>()
                            .Where(u => u.Nif == parsedNif)
                            .ToList();

                        if (students.Any())
                        {
                            MessageBox.Show("Client selected successfully!");
                            this.manager.EditStudentUI(students.First().Nif);
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
                                .Where(u => u.Nif == parsedNif)
                                .ToList();

                        if (teachers.Any())
                        {
                            MessageBox.Show("Client selected successfully!");
                            this.manager.BalanceUI(teachers.First().Nif);
                        }
                        else
                        {
                            Error.Err("Teacher not found!");
                            return;
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void SelectClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }        
    }
}
