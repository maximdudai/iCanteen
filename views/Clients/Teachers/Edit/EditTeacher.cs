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

namespace PSI_DA_PL_B.views.Clients.Teachers.Edit
{
    public partial class EditTeacher : Form
    {

        private int nif;
        private Manager manager { get; set; }
        public EditTeacher()
        {
            InitializeComponent();
        }

        public EditTeacher(int nif, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
            ShowTeacherDetails();
        }

        private void ShowTeacherDetails()
        {
            try
            {
                using (var db = new Cantina())
                {
                    var teacher = db.User
                        .OfType<Teacher>()
                        .Where(u => u.Nif == this.nif)
                        .FirstOrDefault();

                    if (teacher != null)
                    {
                        teacherNameInput.Text = teacher.Name;
                        teacherEmailInput.Text = teacher.Email;
                        teacherNIFinput.Text = teacher.Nif.ToString();
                        teacherBalanceInput.Text = teacher.Balance.ToString();
                    }
                    else
                    {
                        Error.Err("Teacher not found in the database!");
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void TeacherEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Cantina())
                {
                    var teacher = db.User
                        .OfType<Teacher>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                    if (teacher != null)
                    {
                        // Update teacher details
                        teacher.Name = teacherNameInput.Text;
                        teacher.Email = teacherEmailInput.Text;
                        teacher.Nif = int.Parse(teacherNIFinput.Text);
                        teacher.Balance = decimal.Parse(teacherBalanceInput.Text);

                        db.SaveChanges();
                        MessageBox.Show("Teacher details updated successfully!");

                        this.manager.ClientListUI();
                    }
                    else
                    {
                        Error.Err("Teacher not found in the database!");
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void EditTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ClientListUI();
        }
    }
}
