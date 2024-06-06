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
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text;
            if (!Validator.IsUsernameValid(username))
            {
                Error.Warning("Invalid username.");
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
