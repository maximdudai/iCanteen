using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
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

namespace PSI_DA_PL_B.views.Clients.Teachers.Create
{
    public partial class CreateTeacher : Form
    {
        private Manager manager { get; set; }
        private string name { get; set; }
        private int Nif { get; set; }
        private double Balance { get; set; }
        private string Email { get; set; }
        public CreateTeacher()
        {
            InitializeComponent();
        }
        public CreateTeacher(Manager manager) : this()
        {
            this.manager = manager;
        }
        private void TeacherCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.name = teacherNameInput.Text;
                this.Nif = int.Parse(teacherNIFinput.Text);
                this.Email = teacherEmailInput.Text;
                this.Balance = 0.00;

                //TODO validate email

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Email))
                {
                    Error.Err("Name or Email field cannot be empty!");
                    return;
                }

                if (this.Nif.ToString().Length != 9)
                {
                    Error.Err("NIF must have 9 digits!");
                    return;
                }
                               
                //verify if the email and nif already exists
                using (var db = new Cantina())
                {
                    var email = db.User.
                        OfType<Teacher>()
                        .Where(u => u.Email == this.Email)
                        .FirstOrDefault();

                    var userNif = db.User
                        .Where(u => u.Nif == this.Nif)
                        .FirstOrDefault();

                    if (email != null)
                    {
                        Error.Err("Email already exists!");
                        return;
                    }

                    if (userNif != null)
                    {
                        Error.Err("NIF already exists!");
                        return;
                    }
                }

                //create the teacher
                using (var db = new Cantina())
                {
                    Teacher user = new Teacher()
                    {
                        Name = this.name,
                        Nif = this.Nif,
                        Balance = this.Balance,
                        Email = this.Email,
                    };

                    db.User.Add(user);
                    db.SaveChanges();
                }

                this.manager.ClientListUI();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void CreateTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ClientListUI();
        }
    }
}
