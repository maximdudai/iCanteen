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

namespace PSI_DA_PL_B.views.Clients.Students.Edit
{
    public partial class EditStudent : Form
    {
        private string name {  get; set; }
        private int numStudent { get; set; }
        private int nif {  get; set; }
        private double balance { get; set; }

        public EditStudent()
        {
            InitializeComponent();
        }

        public EditStudent (string name, int numStudent, int nif, double balance) : this()
        {
            studentNameInput.Text = name;
            studentNumberInput.Text = numStudent.ToString();
            studentNIFinput.Text = nif.ToString();
            studentBalanceInput.Text = balance.ToString();
        }

        private void StudentEdit_Click(object sender, EventArgs e)
        {
           try
           {
               this.name = studentNameInput.Text;
               this.numStudent = int.Parse(studentNumberInput.Text);
               this.nif = int.Parse(studentNIFinput.Text);
               this.balance = int.Parse(studentBalanceInput.Text);

               if (string.IsNullOrEmpty(this.name))
               {
                   Error.Err("Name field cannot be empty!");
                   return;
               }
               if (this.nif.ToString().Length != 9)
               {
                   Error.Err("NIF must have 9 digits!");
                   return;
               }

               if (this.numStudent.ToString().Length != 7)
               {
                   Error.Err("Number of Student must have 7 digits!");
                   return;
               }

               using (var db = new Cantina())
               {
                   var studentData = db.User.
                       OfType<Student>()
                       .Where(u => u.Nif == this.nif)
                       .FirstOrDefault();

                   if (studentData == null)
                   {
                       Error.Err("Student not found!");
                       return;
                   }

                   // Modify the entity properties
                   studentData.Name = this.name;
                   studentData.NumStudent = this.numStudent;
                   studentData.Nif = this.nif;
                   studentData.Balance = this.balance;

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
