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
using PSI_DA_PL_B.views.Clients.Both;
using PSI_DA_PL_B.views.Clients.Students.Create;
using PSI_DA_PL_B.views.Clients.Teachers.Create;
using PSI_DA_PL_B.views.Auth.Register;
using PSI_DA_PL_B.views.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PSI_DA_PL_B.views.Clients.Students.Edit;
using PSI_DA_PL_B.views.Clients.Teachers.Edit;

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

        //clients
        private ListClients listClientForm = null;
        private ChooseClientCreate ChooseClientForm = null;
        private CreateStudent CreateStudentFrom = null;
        private CreateTeacher CreateTeacherFrom = null;
        private ListClients EditClientForm = null;
        private EditStudent EditStudentForm = null;
        private EditTeacher EditTeacherForm = null;


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

        #region Client Manager
        public void ClientListUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (currentForm != listClientForm || listClientForm == null) 
            {
                listClientForm = new ListClients(this);
            }

            if (toggle && listClientForm != null)
            {
                listClientForm.Show();
                this.currentForm = listClientForm;
            }  
            else
            {
                listClientForm.Close();
            }   
        }

        public void ChooseClientUI (bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (currentForm != ChooseClientForm || ChooseClientForm == null)
            {
                ChooseClientForm = new ChooseClientCreate(this);
            }

            if (toggle && ChooseClientForm != null)
            {
                ChooseClientForm.Show();
                this.currentForm = ChooseClientForm;
            }
            else
            {
                ChooseClientForm.Close();
            }
        }

        public void CreateStudentUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (currentForm != CreateStudentFrom || CreateStudentFrom == null)
            {
                CreateStudentFrom = new CreateStudent(this);
            }

            if (toggle && CreateStudentFrom != null)
            {
                CreateStudentFrom.Show();
                this.currentForm = CreateStudentFrom;
            }
            else
            {
                CreateStudentFrom.Close();
            }
        }
        public void CreateTeacherUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (currentForm != CreateTeacherFrom || CreateTeacherFrom == null)
            {
                CreateTeacherFrom = new CreateTeacher(this);
            }

            if (toggle && CreateTeacherFrom != null)
            {
                CreateTeacherFrom.Show();
                this.currentForm = CreateTeacherFrom;
            }
            else
            {
                CreateTeacherFrom.Close();
            }
        }


        #endregion

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
