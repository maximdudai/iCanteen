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
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees;
using PSI_DA_PL_B.views.Auth.Employees.Create;


namespace PSI_DA_PL_B.views.Auth.Login
{
    public partial class Login : Form
    {
        private string username { get; set; }
        public Login()
        {
            InitializeComponent();
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
                Menu.Menu menu = new Menu.Menu(this.username);
                menu.Show();

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

            CreateEmployee createEmployeeFrom = new CreateEmployee();
            createEmployeeFrom.Show();
            
            //Register.Register register = new Register.Register();
            //register.Show();
            ///this.Show();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            Employees.EmployeeList employee = new Employees.EmployeeList();
            employee.Show();

            this.Hide();
            employee.FormClosing += new FormClosingEventHandler(this.Employee_FormClosing);
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
