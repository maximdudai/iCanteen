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
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;

namespace PSI_DA_PL_B.views.Auth.Employees.Edit
{
    public partial class EditEmployee : Form
    {
        private string username { get; set; }
        private string name { get; set; }
        private int Nif { get; set; }

        public EditEmployee()
        {
            InitializeComponent();
        }

        public EditEmployee(string username, string name, int nif) : this()
        {
            employeeUsernameInput.Text = username;
            employeeNameInput.Text = name;
            employeeNIFinput.Text = nif.ToString();
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



                EmployeeList employeeForm = new EmployeeList();
                employeeForm.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }
    }
}
