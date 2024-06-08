using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees;
using PSI_DA_PL_B.views.Auth.Employees.Create;


namespace PSI_DA_PL_B.views.Auth.Login
{
    public partial class Login : Form
    {
        private string username { get; set; }
        private Manager manager { get; set; }

        public Login(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = loginUsername.Text;
                if (string.IsNullOrWhiteSpace(username))
                {
                    Error.Warning("Username cannot be empty.");
                    return;
                }

                if (!Validator.IsUsernameValid(username))
                {
                    Error.Warning("Invalid username.");
                    return;
                }

                using (var db = new Cantina())
                {
                    var checkUser = db.User
                        .OfType<Employee>()
                        .Where(user => user.Username == username)
                        .Select(user => new
                        {
                            user.Username,
                        })
                        .FirstOrDefault();

                    if (checkUser == null)
                    {
                        Error.Warning("User not found.");
                        return;
                    }

                    this.username = checkUser.Username;
                }

                // Log successful login
                Console.WriteLine("Login successful for user: " + this.username);

                // Proceed to the menu
                Manager manager = new Manager();
                manager.MainMenuUI(true, this.username);

                // Hide the current form
                this.Hide();
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine("An error occurred: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                }
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.CreateEmployeeUI(true);

            this.Close();
        }
    }
}
