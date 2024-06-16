﻿using System;
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
using PSI_DA_PL_B.views.Menu;

namespace PSI_DA_PL_B.controller
{
    public class Manager
    {
        public Form currentForm = null;

        private Login loginForm;
        private CanteenMenu mainMenuForm;
        private CreateEmployee createEmployeeForm;
        private EmployeeList employeeListForm;

        private ListClients listClientForm;

        // Method to handle Login UI
        public void LoginUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (loginForm == null)
            {
                loginForm = new Login(this);
            }

            if (toggle)
                loginForm.Show();
            else
                loginForm.Hide();

            this.currentForm = loginForm;
        }

        // Method to handle Main Menu UI
        public void MainMenuUI(bool toggle = true, string username = "")
        {
            this.DestroyCurrentForm();

            if (mainMenuForm == null)
            {
                mainMenuForm = new CanteenMenu(this, username);
            }

            if (toggle)
                mainMenuForm.Show();
            else
                mainMenuForm.Close();

            this.currentForm = mainMenuForm;
        }

        // Method to handle Create Employee UI
        public void CreateEmployeeUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (createEmployeeForm == null)
            {
                createEmployeeForm = new CreateEmployee(this);
            }

            if (toggle)
                createEmployeeForm.Show();
            else
                createEmployeeForm.Hide();

            this.currentForm = createEmployeeForm;
        }

        // Method to handle Employee List UI
        public void EmployeeListUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (employeeListForm == null)
            {
                employeeListForm = new EmployeeList(this);
            }

            if (toggle)
                employeeListForm.Show();
            else
                employeeListForm.Hide();

            this.currentForm = employeeListForm;
        }

        public void ClientListUI(bool toggle = true)
        {
            this.DestroyCurrentForm();

            if (listClientForm == null) 
            {
                listClientForm = new ListClients(this);
            }

            if (toggle)
                listClientForm.Show();
            else 
                listClientForm.Hide();
            this.currentForm = listClientForm;
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
