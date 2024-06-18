using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.MenuCantina;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees.Create;
using PSI_DA_PL_B.views.Auth.Employees.Edit;
using PSI_DA_PL_B.views.components;
using PSI_DA_PL_B.views.Menu;



namespace PSI_DA_PL_B.views.Auth.Employees
{
    public partial class EmployeeList : Form
    {
        private readonly List<Employee> employees;
        private Manager manager { get; set; }

        public EmployeeList()
        {
            InitializeComponent();
        }

        public EmployeeList(Manager manager) : this()
        {
            this.manager = manager;

            employees = new List<Employee>();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                using (var db = new Cantina())
                {
                    var empList = db.User
                        .OfType<Employee>()
                        .Select(u => new
                        {
                            u.Name,
                            u.Username,
                            u.Nif,
                        })
                        .ToList();

                    foreach (var emp in empList)
                    {
                        Employee employee = new Employee(emp.Name, emp.Nif, emp.Username);
                        employees.Add(employee);
                    }
                }

                this.DisplayEmployees();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        // receiving a list as a parameter
        private void DisplayEmployees()
        {
            employeesList.DataSource = null;
            employeesList.DataSource = employees;
        }

        private void HandleSelectEmployee(object sender, EventArgs e)
        {

        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeName = filterEmployee.Text;

                if (string.IsNullOrEmpty(employeeName))
                {
                    Error.Err("Search field cannot be empty!");
                    return;
                }
                employeesList.DataSource = null;

                employeesList.DataSource = employees.Where(emp => emp.Username.Contains(employeeName)).ToList();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void filterEmployee_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(filterEmployee.Text))
            {
                this.DisplayEmployees();
            }
        }

        private void employeeCreate_Click(object sender, EventArgs e)
        {
            this.manager.CreateEmployeeUI();
        }

        private void editEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedEmployee = employeesList.SelectedItem as models.User.Employee;

                if (selectedEmployee != null)
                {
                    int nif = selectedEmployee.Nif;

                    this.manager.EditEmployeeUI(nif);
                }
                else
                {
                    Error.Err("Please select an employee to edit!");
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void ShowEmployeeList(object sender, FormClosingEventArgs e)
        {
            this.DisplayEmployees();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedEmployee = employeesList.SelectedItem as models.User.Employee;

                if (selectedEmployee != null)
                {
                    using (var db = new Cantina())
                    {
                        var employee = db.User
                            .OfType<Employee>()
                            .Where(u => u.Name == selectedEmployee.Name)
                            .FirstOrDefault();

                        if (employee != null)
                        {
                            db.User.Remove(employee);
                            db.SaveChanges();
                        }
                    }
                    employees.Remove(selectedEmployee);
                    this.DisplayEmployees();
                }
                else
                {
                    Error.Err("Please select an employee to delete!");
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void EmployeeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }
    }
}
