using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.views.Auth.Employees;
using PSI_DA_PL_B.views.Auth.Employees.Create;
using PSI_DA_PL_B.views.Auth.Employees.Edit;
using PSI_DA_PL_B.views.Auth.Login;
using PSI_DA_PL_B.views.Auth.Register;
using PSI_DA_PL_B.views.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSI_DA_PL_B.controller
{
    public class Manager
    {
        public Form currentForm = null;

        private Login loginForm = null;
        private CanteenMenu mainMenuForm = null;
        private CreateEmployee createEmployeeForm = null;
        private EmployeeList employeeListForm = null;
        private Register registerForm = null;


        // Method to handle Login UI
        public void LoginUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            // If the current form is not the login form, create a new instance of it
            // and assign it to the loginForm variable
            if (currentForm != loginForm || loginForm == null)
            {
                loginForm = new Login(this);
            }

            if (toggle && loginForm != null)
            { 
                loginForm.Show();
                this.currentForm = loginForm;
            }
            else
            {
                loginForm.Close();
            }

        }

        public void RegisterUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (currentForm != registerForm || registerForm == null)
            {
                registerForm = new Register(this);
            }

            if (toggle && registerForm != null)
            {
                registerForm.Show();
                this.currentForm = registerForm;
            }
            else
            {
                registerForm.Close();
            }
        }

        // Method to handle Main Menu UI
        public void MainMenuUI(bool toggle = true, string username = "")
        {
            this.DestroyCurrentForm();

            if (currentForm != mainMenuForm || mainMenuForm == null)
            {
                mainMenuForm = new CanteenMenu(this, username);
            }

            if (toggle && mainMenuForm != null)
            {
                mainMenuForm.Show();
                this.currentForm = mainMenuForm;
            }
            else
            {
                mainMenuForm.Close();
            }
        }

        // Method to handle Create Employee UI
        public void CreateEmployeeUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (currentForm != createEmployeeForm || createEmployeeForm == null)
            {
                createEmployeeForm = new CreateEmployee(this);
            }

            if (toggle && createEmployeeForm != null)
            {
                createEmployeeForm.Show();
                this.currentForm = createEmployeeForm;
            }
            else
            {
                createEmployeeForm.Close();
            }
        }

        // Method to handle Employee List UI
        public void EmployeeListUI(bool toggle = true)
        {
            this.DestroyCurrentForm();
            
            if (currentForm != employeeListForm || employeeListForm == null)
            {
                employeeListForm = new EmployeeList(this);
            }

            if (toggle && employeeListForm != null)
            {
                employeeListForm.Show();
                this.currentForm = employeeListForm;
            }
            else
            {
                employeeListForm.Close();
            }
        }

        // Method to destroy the current form
        private void DestroyCurrentForm()
        {
            try
            {
                if (this.currentForm != null)
                {
                    this.currentForm.Close();
                    this.currentForm = null;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as necessary
                Console.WriteLine($"Error closing form: {ex.Message}");
            }
        }
    }
}
