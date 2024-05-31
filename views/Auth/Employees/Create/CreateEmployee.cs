using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Utilizador;

namespace PSI_DA_PL_B.views.Auth.Employees.Create
{
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
        }

        private void employeeCreate_Click(object sender, EventArgs e)
        {
            string username = employeeUsernameInput.Text;
            string name = employeeNameInput.Text;
            int NIF = int.Parse(employeeNIFinput.Text);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name))
            {
                Error.Err("Username or Name field cannot be empty!");
                return;
            }

            if(NIF.ToString().Length != 9)
            {
                Error.Err("NIF must have 9 digits!");
                return;
            }

            // verify if the username already exists
            using (var db = new Cantina())
            {
                var user = db.Utilizador
                    .Where(u => u.Username == username)
                    .FirstOrDefault();

                if (user != null)
                {
                    Error.Err("Username already exists!");
                    return;
                }
            }

            // create the user
            using (var db = new Cantina())
            {
                Utilizador user = new Utilizador()
                {
                    Nome = name,
                    Username = username,
                    Nif = NIF,
                    funcId = 1
                };

                db.Utilizador.Add(user);
                db.SaveChanges();
            }
            Employee employee = new Employee();
            employee.Show();
            this.Close();
        }
    }
}
