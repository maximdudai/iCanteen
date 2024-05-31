using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Utilizador;
using PSI_DA_PL_B.views.Auth.Employees.Create;
using PSI_DA_PL_B.views.Auth.Employees.Edit;
using PSI_DA_PL_B.views.components;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSI_DA_PL_B.views.Auth.Employees
{
    public partial class Employee : Form
    {
        private readonly List<Funcionario> funcionarios;

        public Employee()
        {
            InitializeComponent();
            funcionarios = new List<Funcionario>();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                using (var db = new Cantina())
                {
                    var funcList = db.Utilizador
                        .OfType<Funcionario>()
                        .Select(u => new
                        {
                            u.Nome,
                            u.Username,
                            u.Nif,
                        })
                        .ToList();

                    foreach (var emp in funcList)
                    {
                        Funcionario funcionario = new Funcionario(emp.Nome, emp.Nif, emp.Username);
                        funcionarios.Add(funcionario);
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
            employeesList.DataSource = funcionarios;
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

                employeesList.DataSource = funcionarios.Where(emp => emp.Username.Contains(employeeName)).ToList();
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
            CreateEmployee createEmployeeFrom = new CreateEmployee();
            createEmployeeFrom.Show();
            this.Close();
        }

        private void editEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedEmployee = employeesList.SelectedItem as Funcionario;
                if (selectedEmployee != null)
                {
                    string username = selectedEmployee.Username;
                    string name = selectedEmployee.Nome;
                    int nif = selectedEmployee.Nif;

                    EditEmployee editEmployeeForm = new EditEmployee(username, name, nif);
                    editEmployeeForm.Show();

                    this.Close();
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

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedEmployee = employeesList.SelectedItem as Funcionario;

                if (selectedEmployee != null)
                {
                    using (var db = new Cantina())
                    {
                        var funcionario = db.Utilizador
                            .OfType<Funcionario>()
                            .Where(u => u.Nome == selectedEmployee.Nome)
                            .FirstOrDefault();

                        if (funcionario != null)
                        {
                            db.Utilizador.Remove(funcionario);
                            db.SaveChanges();
                        }
                    }

                    funcionarios.Remove(selectedEmployee);
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
    }
}
