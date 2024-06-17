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
using PSI_DA_PL_B.views.Menu.Dish.Create;
using PSI_DA_PL_B.views.Menu.Dish;

namespace PSI_DA_PL_B.controller
{
    public class Manager
    {
        public Form currentForm = null;

        public string username { get; set; }

        #region Main forms
        private Login loginForm = null;
        private CanteenMenu mainMenuForm = null;
        private CreateEmployee createEmployeeForm = null;
        private EmployeeList employeeListForm = null;
        private Register registerForm = null;

        private bool isClosing = false;
        #endregion

        #region Client Manager
        private ListClients listClientForm = null;
        private ChooseClientCreate ChooseClientForm = null;
        private CreateStudent CreateStudentFrom = null;
        private CreateTeacher CreateTeacherFrom = null;
        private EditStudent EditStudentForm = null;
        private EditTeacher EditTeacherForm = null;
        #endregion

        #region Menu Manager
        private CreateDish CreateDishForm = null;
        private Dish DishListForm = null;
        #endregion

        private void ShowForm<T>(ref T form, bool toggle = true, params object[] args) where T : Form
        {
            if (isClosing)
                return;

            this.DestroyCurrentForm();

            if (currentForm == null || currentForm.GetType() != typeof(T))
            {
                form = (T)Activator.CreateInstance(typeof(T), args);
            }

            if (toggle && form != null)
            {
                form.Show();
                this.currentForm = form;
            }
            else if (form != null)
            {
                form.Close();
            }
        }


        // Method to handle Login UI
        public void LoginUI(bool toggle = true)
        {
            ShowForm(ref loginForm, toggle, this);
        }

        public void RegisterUI(bool toggle = true)
        {
            ShowForm(ref registerForm, toggle, this);
        }

        public void MainMenuUI(string username = null, bool toggle = true)
        {
            ShowForm(ref mainMenuForm, toggle, this, username ?? this.username);
        }

        public void CreateEmployeeUI(bool toggle = true)
        {
            ShowForm(ref createEmployeeForm, toggle, this);
        }

        public void EmployeeListUI(bool toggle = true)
        {
            ShowForm(ref employeeListForm, toggle, this);
        }

        public void ClientListUI(bool toggle = true)
        {
            ShowForm(ref listClientForm, toggle, this);
        }

        public void ChooseClientUI(bool toggle = true)
        {
            ShowForm(ref ChooseClientForm, toggle, this);
        }

        public void CreateStudentUI(bool toggle = true)
        {
            ShowForm(ref CreateStudentFrom, toggle, this);
        }

        public void CreateTeacherUI(bool toggle = true)
        {
            ShowForm(ref CreateTeacherFrom, toggle, this);
        }

        public void ShowDishListUI(bool toggle = true)
        {
            ShowForm(ref DishListForm, toggle, this);
        }
        public void ShowCreateDishUI(bool toggle = true)
        {
            ShowForm(ref CreateDishForm, toggle, this);
        }

        public void EditStudentUI(int nif, bool toggle = true)
        {
            ShowForm(ref EditStudentForm, toggle, nif, this);
        }
        public void EditTeacherUI(int nif, bool toggle = true)
        {
            ShowForm(ref EditTeacherForm, toggle, nif, this);
        }

        // Method to destroy the current form
        private void DestroyCurrentForm()
        {
            if (isClosing)
                return;

            try
            {
                if (this.currentForm != null)
                {
                    isClosing = true;
                    this.currentForm.Close();
                    this.currentForm = null;
                    isClosing = false;
                }
            }
            catch (Exception ex)
            {
                isClosing = false;
                Console.WriteLine($"Error closing form: {ex.Message}");
            }
        }

    }
}
