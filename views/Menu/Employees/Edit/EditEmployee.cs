using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;

namespace PSI_DA_PL_B.views.Auth.Employees.Edit
{
    public partial class EditEmployee : Form
    {
        Manager manager { get; set; }
        private string username { get; set; }
        private string name { get; set; }
        private int Nif { get; set; }

        public EditEmployee()
        {
            InitializeComponent();
        }

        public EditEmployee(int nif, Manager manager) : this()
        {
            this.manager = manager;

            this.GetEmployeeData(nif);
        }

        public void GetEmployeeData(int nif)
        {
            try
            {
                using (var db = new Cantina())
                {
                    var employeeData = db.User
                        .OfType<Employee>()
                        .Where(u => u.Nif == nif)
                        .FirstOrDefault();

                    if (employeeData == null)
                    {
                        Error.Err("Employee not found!");
                        return;
                    }

                    this.username = employeeUsernameInput.Text = employeeData.Username;
                    this.name = employeeNameInput.Text = employeeData.Name;
                    
                    employeeNIFinput.Text = employeeData.Nif.ToString();
                    this.Nif = employeeData.Nif;
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void employeeEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.username = employeeUsernameInput.Text;
                this.name = employeeNameInput.Text;
                this.Nif = int.Parse(employeeNIFinput.Text);

                if (string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.name))
                {
                    Error.Err("Username or Name field cannot be empty!");
                    return;
                }
                if (this.Nif.ToString().Length != 9)
                {
                    Error.Err("NIF must have 9 digits!");
                    return;
                }

                using (var db = new Cantina())
                {
                    // Fetch the Funcionario entity that needs to be updated
                    var employeeData = db.User
                        .OfType<Employee>()
                        .Where(u => u.Username == this.username)
                        .FirstOrDefault();

                    if (employeeData == null)
                    {
                        Error.Err("Employee not found!");
                        return;
                    }

                    // Check if there's another user with the same new username or NIF
                    var duplicateCheck = db.User
                        .OfType<Employee>()
                        .Where(u => (u.Username == this.username || u.Nif == this.Nif) && u.Id != employeeData.Id)
                        .FirstOrDefault();

                    if (duplicateCheck != null)
                    { 
                        Error.Err("User with this information already exists!");
                        return;
                    }

                    // Modify the entity properties
                    employeeData.Name = this.name;
                    employeeData.Nif = this.Nif;
                    employeeData.Username = this.username;

                    // Save changes to the database
                    db.SaveChanges();
                }
                this.manager.EmployeeListUI();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }
    }
}
