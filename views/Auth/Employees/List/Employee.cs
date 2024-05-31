using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Utilizador;
using PSI_DA_PL_B.views.Auth.Employees.Create;
using PSI_DA_PL_B.views.components;

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
            using(var db = new Cantina())
            {
                var funcList = db.Utilizador
                    .Where(f => f.funcId == 1)
                    .Select(u => new
                    {
                        u.Nome,
                        u.Nif,
                        u.Username
                    })
                    .ToList();
                
                foreach(var emp in funcList) {
                    Funcionario funcionario = new Funcionario(emp.Nome, emp.Nif, emp.Username);
                    funcionarios.Add(funcionario);
                }
            }

            this.DisplayEmployees();
        }

        // Display employees in the listBox

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
            string employeeName = filterEmployee.Text;

            if(string.IsNullOrEmpty(employeeName))
            {
                Error.Err("Search field cannot be empty!");
                return;
            }
            employeesList.DataSource = null;
            foreach(var emp in funcionarios)
            {

                if(emp.Username.Contains(employeeName))
                {
                    employeesList.DataSource = new List<Funcionario> { emp };
                    return;
                }
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
        
    }
}
