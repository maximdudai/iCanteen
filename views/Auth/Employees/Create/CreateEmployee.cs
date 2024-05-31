using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Utilizador;

namespace PSI_DA_PL_B.views.Auth.Employees.Create
{
    public partial class CreateEmployee : Form
    {
        private string username { get; set; }
        private string name { get; set; }
        private int Nif { get; set; }

        public CreateEmployee()
        {
            InitializeComponent();
        }

        private void employeeCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.username = employeeUsernameInput.Text;
                this.name = employeeNameInput.Text;
                this.Nif = int.Parse(employeeNIFinput.Text);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name))
                {
                    Error.Err("Username or Name field cannot be empty!");
                    return;
                }

                if (this.Nif.ToString().Length != 9)
                {
                    Error.Err("NIF must have 9 digits!");
                    return;
                }

                // verify if the username already exists
                using (var db = new Cantina())
                {
                    var user = db.Utilizador.
                        OfType<Funcionario>()
                        .Where(u => u.Username == this.username)
                        .FirstOrDefault();

                    var userNif = db.Utilizador
                        .Where(u => u.Nif == this.Nif)
                        .FirstOrDefault();

                    if (user != null)
                    {
                        Error.Err("Username already exists!");
                        return;
                    }

                    if (userNif != null)
                    {
                        Error.Err("NIF already exists!");
                        return;
                    }
                }

                // create the user
                using (var db = new Cantina())
                {
                    Funcionario user = new Funcionario()
                    {
                        Nome = this.name,
                        Nif = this.Nif,
                        Username = this.username,
                    };

                    db.Utilizador.Add(user);
                    db.SaveChanges();
                }
                Employee employee = new Employee();
                employee.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }
    }
}
