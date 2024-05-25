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
using PSI_DA_PL_B.models.Utilizador;
using PSI_DA_PL_B.views.Auth.Employees;

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

            // Display menu form
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ShowDialog();

        }
    }
}
