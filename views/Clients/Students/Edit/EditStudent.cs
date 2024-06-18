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
using System.Xml.Linq;
using static PSI_DA_PL_B.views.Clients.Both.ListClients;

namespace PSI_DA_PL_B.views.Clients.Students.Edit
{
    public partial class EditStudent : Form
    {        
        private int nif;
        private Manager manager { get; set; }

        public EditStudent()
        {
            InitializeComponent();
        }
        public EditStudent(int nif, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
            ShowStudentDetails();
        }
        private void ShowStudentDetails()
        {
            try
            {
                using (var db = new Cantina())
                {
                    var student = db.User
                        .OfType<Student>()
                        .Where(u => u.Nif == this.nif)
                        .FirstOrDefault();

                    if (student != null)
                    {
                        studentNameInput.Text = student.Name;
                        studentNumberInput.Text = student.NumStudent.ToString();
                        studentNIFinput.Text = student.Nif.ToString();
                        studentBalanceInput.Text = student.Balance.ToString();
                    }
                    else
                    {
                        Error.Err("Student not found in the database!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
                this.Close();
            }
        }

        private void StudentEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (var db = new Cantina())
                {
                    var student = db.User
                        .OfType<Student>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                    if (student != null)
                    {
                        // Update student details
                        student.Name = studentNameInput.Text;
                        student.NumStudent = int.Parse(studentNumberInput.Text);
                        student.Nif = int.Parse(studentNIFinput.Text);
                        student.Balance = double.Parse(studentBalanceInput.Text);

                        db.SaveChanges();
                        MessageBox.Show("Student details updated successfully!");

                        this.manager.ClientListUI();
                    }
                    else
                    {
                        Error.Err("Student not found in the database!");
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void EditStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ClientListUI();
        }
    }
}
