using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Clients.Both;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Menu.Balance
{
    public partial class Balance : Form
    {
        private Manager manager { get; set; }
        private int nif;

        public Balance()
        {
            InitializeComponent();
        }

        public Balance(int nif, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
            LoadClientInf();
        }

        private void LoadClientInf()
        {
            try 
            {
                using (var db = new Cantina())
                {
                    var selectedstudent = db.User
                        .OfType<Student>()
                        .Where(u => u.Nif == this.nif)
                        .Select(u => new
                        {
                            u.Name,
                            u.Nif,
                            u.Balance,
                        })
                    .FirstOrDefault();

                    if (selectedstudent != null)
                    {
                        ClientNameInput.Text = selectedstudent.Name;
                        ClientNifInput.Text = selectedstudent.Nif.ToString();
                        ClientTypeInput.Text = "Estudante";
                        CurrentBalance.Text = selectedstudent.Balance.ToString("");
                    }

                    var selectedteacher = db.User
                        .OfType<Teacher>()
                        .Where(u => u.Nif == this.nif)
                        .Select(u => new
                        {
                            u.Name,
                            u.Nif,
                            u.Balance,
                        })
                    .FirstOrDefault();

                    if (selectedteacher != null)
                    {
                        ClientNameInput.Text = selectedteacher.Name;
                        ClientNifInput.Text = selectedteacher.Nif.ToString();
                        ClientTypeInput.Text = "Professor";
                        CurrentBalance.Text = selectedteacher.Balance.ToString("");
                    }                 
                }                
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void LoadBalanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valueToLoad = ValueToLoad.Value;

                using (var db = new Cantina())
                {
                    var selectedstudent = db.User
                        .OfType<Student>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                    if (selectedstudent != null)
                    {
                        selectedstudent.Balance = selectedstudent.Balance + valueToLoad;
                        db.SaveChanges();

                        MessageBox.Show("Account balance successfully loaded!");
                        this.manager.MainMenuUI();
                    }

                    var selectedteacher = db.User
                        .OfType<Teacher>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                    if (selectedteacher != null)
                    {
                        selectedteacher.Balance = selectedteacher.Balance + valueToLoad;
                        db.SaveChanges();

                        MessageBox.Show("Account balance successfully loaded!");
                        this.manager.MainMenuUI();
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void Balance_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }
    }
}
