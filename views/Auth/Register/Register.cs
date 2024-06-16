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
using PSI_DA_PL_B.models.User;

namespace PSI_DA_PL_B.views.Auth.Register
{
    public partial class Register : Form
    {
        Manager manager;
        public Register(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            string name = registerName.Text;
            int nif = int.TryParse(registerNif.Text, out int result) ? result : 0;
            string username = registerUsername.Text;


            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(registerNif.Text) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (nif.ToString().Length != 9)
            {
                Error.Warning("NIF must have 9 digits.");
                return;
            }

            using (var db = new Cantina())
            {
                var checkUser = db.User
                    .OfType<Employee>()
                    .Where(user => user.Nif == nif || user.Username == username)
                    .Select(user => new
                    {
                        user.Username,
                    })
                    .FirstOrDefault();

                if (checkUser != null)
                {
                    MessageBox.Show("An user with specified details already exists!");
                    return;
                }

                Employee employee = new Employee
                {
                    Name = name,
                    Nif = nif,
                    Username = username,
                };

                db.User.Add(employee);
                db.SaveChanges();
            }
            this.manager.MainMenuUI(username);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.manager.LoginUI(true);
        }
    }
}
