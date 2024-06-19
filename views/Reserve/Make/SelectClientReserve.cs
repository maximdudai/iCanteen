using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Reserve.Make
{
    public partial class SelectClientReserve : Form
    {
        private Manager manager { get; set; }
        private int clientNifInput;

        public SelectClientReserve()
        {
            InitializeComponent();
            InitializeRadioButtonEvents();
        }

        public SelectClientReserve(Manager manager) : this()
        {
            this.manager = manager;
        }

        #region Button Event
        //CheckedChanged to radio buttons
        private void InitializeRadioButtonEvents()
        {
            ClientRadioButton.CheckedChanged += new EventHandler(ClientRadioButton_CheckedChanged);
            NewClientRadioButton.CheckedChanged += new EventHandler(NewClientRadioButton_CheckedChanged);
            NewExpressClientRadioButton.CheckedChanged += new EventHandler(NewExpressClientRadioButton_CheckedChanged);
        }
        //show the searchClientNif when there is a client
        private void ClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchClientNif.Visible = ClientRadioButton.Checked;
        }

        //hide searchClientNif when you are a new client
        private void NewClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchClientNif.Visible = !(NewClientRadioButton.Checked || NewExpressClientRadioButton.Checked);
        }

        //keeps searchClientNif when creating an express client
        private void NewExpressClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchClientNif.Visible = NewExpressClientRadioButton.Checked;
        }
        #endregion

        private void searchClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClientRadioButton.Checked && !NewClientRadioButton.Checked && !NewExpressClientRadioButton.Checked)
                {
                    Error.Err("Not selected the status of client!");
                    return;
                }

                if (!StudentRadioButton.Checked && !TeacherRadioButton.Checked)
                {
                    Error.Err("Not selected the type of client!");
                    return;
                }

                //new client
                if (NewClientRadioButton.Checked)
                {
                    if (StudentRadioButton.Checked)
                    {
                        this.manager.CreateStudentUI();
                    }
                    else if (TeacherRadioButton.Checked)
                    {
                        this.manager.CreateTeacherUI();
                    }

                    return;
                }

                //new express client
                if (NewExpressClientRadioButton.Checked)
                {
                    if (StudentRadioButton.Checked)
                    {
                        CreateExpressStudent();
                    }
                    else if (TeacherRadioButton.Checked)
                    {
                        CreateExpressTeacher();
                    }

                    return;
                }

                //existing client
                if (ClientRadioButton.Checked)
                {
                    if (string.IsNullOrWhiteSpace(searchClientNif.Text))
                    {
                        Error.Err("Please enter the client's NIF!");
                        return;
                    }

                    this.clientNifInput = int.Parse(searchClientNif.Text);

                    if (!Validator.IsValidClientNifSearch(this.clientNifInput))
                    {
                        return;
                    }

                    using (var db = new Cantina())
                    {
                        if (StudentRadioButton.Checked)
                        {
                            var student = db.User
                                .OfType<Student>()
                                .FirstOrDefault(u => u.Nif == this.clientNifInput);

                            if (student != null)
                            {
                                this.manager.MakeReserveUI(student.Nif, "Estudante");
                            }
                            else
                            {
                                Error.Err("Student not found!");
                            }
                        }

                        if (TeacherRadioButton.Checked)
                        {
                            var teacher = db.User
                                    .OfType<Teacher>()
                                    .FirstOrDefault(u => u.Nif == this.clientNifInput);

                            if (teacher != null)
                            {
                                this.manager.MakeReserveUI(teacher.Nif, "Professor");
                            }
                            else
                            {
                                Error.Err("Teacher not found!");
                            }
                        }
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void CreateExpressStudent()
        {
            try
            {
                int nif = int.Parse(searchClientNif.Text);

                using (var db = new Cantina())
                {
                    var student = db.User
                        .OfType<Student>()
                        .FirstOrDefault(u => u.Nif == nif);

                    if (student != null)
                    {
                        Error.Err("NIF already exists!");
                        return;
                    }

                    Student user = new Student
                    {
                        Name = "RegistoSimplificado",
                        Nif = nif,
                        Balance = 0.00M,
                        NumStudent = 999999999
                    };
                    db.User.Add(user);
                    db.SaveChanges();
                }
                MessageBox.Show("Student created successfully!");
                this.manager.MakeReserveUI(nif,"Estudante");
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void CreateExpressTeacher()
        {
            try
            {
                int nif = int.Parse(searchClientNif.Text);
                
                using (var db = new Cantina())
                {
                    var teacher = db.User
                        .OfType<Teacher>()
                        .FirstOrDefault(u => u.Nif == nif);
                    
                    if (teacher != null)
                    {
                        Error.Err("NIF already exists!");
                        return;
                    }

                    Teacher user = new Teacher
                    {
                        Name = "RegistoSimplificado",
                        Nif = nif,
                        Balance = 0.00M,
                        Email = "registosimplificado@gmail.com"
                    };
                    db.User.Add(user);
                    db.SaveChanges();
                }
                MessageBox.Show("Teacher created successfully!");
                this.manager.MakeReserveUI(nif, "Professor");
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void SelectClientReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }        
    }
}
