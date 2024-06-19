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
using PSI_DA_PL_B.views.Menu.Balance;
using PSI_DA_PL_B.views.Menu.Dish.Edit;
using PSI_DA_PL_B.views.Menu.Extra.Edit;
using PSI_DA_PL_B.views.Menu.Extra.Create;
using PSI_DA_PL_B.views.Menu.MenuList;
using PSI_DA_PL_B.views.Menu.MenuList.Create;
using PSI_DA_PL_B.views.Menu.MenuList.Edit;

namespace PSI_DA_PL_B.controller
{
    public class Manager
    {
        public Form currentForm = null;

        public string username { get; set; }

        #region Main Form
        private Login loginForm = null;
        private CanteenMenu mainMenuForm = null;
        private Register registerForm = null;
        private Balance BalanceForm = null;
        #endregion

        private bool isClosing = false;

        #region Employee Form
        private CreateEmployee CreateEmployeeForm = null;
        private EmployeeList EmployeeListForm = null;
        private EditEmployee EditEmployeeForm = null;
        #endregion

        #region Client Form
        private ListClients listClientForm = null;
        private ChooseClientCreate ChooseClientForm = null;
        private CreateStudent CreateStudentFrom = null;
        private CreateTeacher CreateTeacherFrom = null;
        private EditStudent EditStudentForm = null;
        private EditTeacher EditTeacherForm = null;
        private SelectClient SelectClientForm = null;
        #endregion

        #region Menu Form
        private CreateDish CreateDishForm = null;
        private Dish DishListForm = null;
        private EditDish EditDishForm = null;
        private ExtraMenu ExtraListForm = null;
        private EditExtra EditExtraForm = null;
        private CreateExtra CreateExtraForm = null;
        private MenuList MenuListForm = null;
        private CreateMenu CreateMenuForm = null;
        private EditMenu EditMenuForm = null;
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

        #region Main Manager
        // Method to handle Login UI
        public void LoginUI(bool toggle = true)
        {
            ShowForm(ref loginForm, toggle, this);
        }
        public void MainMenuUI(string username = null, bool toggle = true)
        {
            ShowForm(ref mainMenuForm, toggle, this, username ?? this.username);
        }
        public void RegisterUI(bool toggle = true)
        {
            ShowForm(ref registerForm, toggle, this);
        }
        public void BalanceUI(int nif, bool toggle = true)
        {
            ShowForm(ref BalanceForm, toggle, nif, this);
        }
        #endregion


        #region Emmployed Manager
        public void EmployeeListUI(bool toggle = true)
        {
            ShowForm(ref EmployeeListForm, toggle, this);
        }
        public void CreateEmployeeUI(bool toggle = true)
        {
            ShowForm(ref CreateEmployeeForm, toggle, this);
        }
        public void EditEmployeeUI(int nif, bool toggle = true)
        {
            ShowForm(ref EditEmployeeForm, toggle, nif, this);
        }
        #endregion


        #region Client Manager
        public void ClientListUI(bool toggle = true)
        {
            ShowForm(ref listClientForm, toggle, this);
        }
        public void CreateStudentUI(bool toggle = true)
        {
            ShowForm(ref CreateStudentFrom, toggle, this);
        }
        public void CreateTeacherUI(bool toggle = true)
        {
            ShowForm(ref CreateTeacherFrom, toggle, this);
        }
        public void ChooseClientUI(bool toggle = true)
        {
            ShowForm(ref ChooseClientForm, toggle, this);
        }

        public void EditStudentUI(int nif, bool toggle = true)
        {
            ShowForm(ref EditStudentForm, toggle, nif, this);
        }
        public void EditTeacherUI(int nif, bool toggle = true)
        {
            ShowForm(ref EditTeacherForm, toggle, nif, this);
        }
        public void SelectClientUI(string menu, bool toggle = true)
        {
            ShowForm(ref SelectClientForm, toggle, menu, this);
        }
        #endregion


        #region Menu Manager
        public void ShowDishListUI(bool toggle = true)
        {
            ShowForm(ref DishListForm, toggle, this);
        }
        public void ShowCreateDishUI(bool toggle = true)
        {
            ShowForm(ref CreateDishForm, toggle, this);
        }
        public void ShowEditDishUI(int itemId, bool toggle = true)
        {
            ShowForm(ref EditDishForm, toggle, itemId, this);
        }
        public void ShowExtraListUI(bool toggle = true)
        {
            ShowForm(ref ExtraListForm, toggle, this);
        }

        public void ShowCreateExtraUI(bool toggle = true)
        {
            ShowForm(ref CreateExtraForm, toggle, this);
        }
        public void ShowEditExtraUI(int itemId, bool toggle = true)
        {
            ShowForm(ref EditExtraForm, toggle, itemId, this);
        }

        public void ShowMenuListUI(bool toggle = true)
        {
            ShowForm(ref MenuListForm, toggle, this);
        }

        public void ShowCreateMenuUI(bool toggle = true)
        {
            ShowForm(ref CreateMenuForm, toggle, this);
        }
        public void ShowEditMenuUI(int menu_id, bool toggle = true)
        {
            ShowForm(ref EditMenuForm, toggle, menu_id, this);
        }
        #endregion


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
