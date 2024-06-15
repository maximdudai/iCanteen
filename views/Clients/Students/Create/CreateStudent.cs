using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees;
using PSI_DA_PL_B.views.Clients.Both;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSI_DA_PL_B.views.Clients.Students.Create
{
    public partial class CreateStudent : Form
    {
        private string name { get; set; }
        private int Nif { get; set; }
        private double Balance { get; set; }
        private int NumStudent { get; set; }
        public CreateStudent()
        {
            InitializeComponent();
        }

        private void StudentCreate_Click(object sender, EventArgs e)
        {
            try 
            {
                this.name = studentNameInput.Text;
                this.Nif = int.Parse(studentNIFinput.Text);
                this.NumStudent = int.Parse(studentNumberInput.Text);
                this.Balance = 0.00;

                if (string.IsNullOrEmpty(name))
                {
                    Error.Err("Name field cannot be empty!");
                    return;
                }

                if (this.Nif.ToString().Length != 9)
                {
                    Error.Err("NIF must have 9 digits!");
                    return;
                }

                if (this.NumStudent.ToString().Length != 7)
                {
                    Error.Err("Number of Student must have 7 digits!");
                    return;
                }

                //verify if the numstudent and nif already exists
                using (var db = new Cantina())
                {
                    var number = db.User.
                        OfType<Student>()
                        .Where(u => u.NumStudent == this.NumStudent)
                        .FirstOrDefault();

                    var userNif = db.User
                        .Where(u => u.Nif == this.Nif)
                        .FirstOrDefault();

                    if (number != null)
                    {
                        Error.Err("Number of Student already exists!");
                        return;
                    }

                    if (userNif != null)
                    {
                        Error.Err("NIF already exists!");
                        return;
                    }
                }

                //create the student
                using (var db = new Cantina())
                {
                    Student user = new Student()
                    {
                        Name = this.name,
                        Nif = this.Nif,
                        Balance = this.Balance,
                        NumStudent = this.NumStudent,
                    };

                    db.User.Add(user);
                    db.SaveChanges();
                }
                ListClients client = new ListClients();
                client.Show();

                this.Close();

            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }
    }
}
