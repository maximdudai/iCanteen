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

namespace PSI_DA_PL_B.views.Clients.Teachers.Edit
{
    public partial class EditTeacher : Form
    {

        private string name { get; set; }
        private string email { get; set; }
        private int nif { get; set; }
        private double balance { get; set; }

        public EditTeacher()
        {
            InitializeComponent();
        }

        public EditTeacher(string name, string email, int nif, double balance) : this()
        {
            teacherNameInput.Text = name;
            teacherEmailInput.Text = email;
            teacherNIFinput.Text = nif.ToString(); ;
            teacherBalanceInput.Text = balance.ToString(); ;
        }

        private void TeacherEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.name = teacherNameInput.Text;
                this.email = teacherEmailInput.Text;
                this.nif = int.Parse(teacherNIFinput.Text);
                this.balance = int.Parse(teacherBalanceInput.Text);

                if (string.IsNullOrEmpty(this.name) || string.IsNullOrEmpty(this.email))
                {
                    Error.Err("Name or Email field cannot be empty!");
                    return;
                }
                if (this.nif.ToString().Length != 9)
                {
                    Error.Err("NIF must have 9 digits!");
                    return;
                }

                using (var db = new Cantina())
                {
                    var teacherData = db.User.
                        OfType<Teacher>()
                        .Where(u => u.Nif == this.nif)
                        .FirstOrDefault();

                    if (teacherData == null)
                    {
                        Error.Err("Student not found!");
                        return;
                    }

                    // Modify the entity properties
                    teacherData.Name = this.name;
                    teacherData.Email = this.email;
                    teacherData.Nif = this.nif;
                    teacherData.Balance = this.balance;

                    // Save changes to the database
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
