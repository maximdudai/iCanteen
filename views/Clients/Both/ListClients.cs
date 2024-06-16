using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees;
using PSI_DA_PL_B.views.Clients.Students.Edit;
using PSI_DA_PL_B.views.Clients.Teachers.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PSI_DA_PL_B.views.Clients.Both
{
    public partial class ListClients : Form
    {
        private readonly List<Client> clients;
        private Manager manager { get; set; }

        //to join the queries
        public class ClientInfo
        {
            public string Name { get; set; }
            public int Nif { get; set; }
            public double Balance { get; set; }
            public int? NumStudent { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                var text = $"Nome: {Name}; Nif: {Nif} ";

                if(NumStudent.HasValue)
                {
                    text += $"; NumEst: {NumStudent}";
                }
                if (!string.IsNullOrEmpty(Email))
                {
                    text += $"; Email: {Email}";
                }
                return text ;
            }
        }

        public ListClients()
        {
            InitializeComponent();
        }

        public ListClients(Manager manager):this()
        {
            this.manager = manager;
            clients = new List<Client>();
            LoadClients();
        }

        private void LoadClients()
        {
            try
            {
                using (var db = new Cantina())
                {
                    var studentList = db.User
                        .OfType<Student>()
                        .Select(u => new ClientInfo
                        {
                            Name = u.Name,
                            Nif = u.Nif,
                            Balance = u.Balance,
                            NumStudent = u.NumStudent,
                            Email = null
                        }).ToList();

                    var teacherList = db.User
                        .OfType<Teacher>()
                        .Select(u => new ClientInfo
                        {
                            Name = u.Name,
                            Nif = u.Nif,
                            Balance = u.Balance,
                            NumStudent = null,
                            Email = u.Email
                        }).ToList();

                    var clientList = studentList.Concat(teacherList).ToList();

                    clientsListbox.Items.Clear();

                    foreach (var cli in clientList)
                    {
                        clientsListbox.Items.Add(cli);
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        //receiving a list as a parameter
        private void DisplayClients()
        {
            clientsListbox.DataSource = null;
            clientsListbox.DataSource = clients;
        }

        //search by client name
        private void SearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                string clientName = filterClient.Text;

                if (string.IsNullOrEmpty(clientName))
                {
                    Error.Err("Search field cannot be empty!");
                    return;
                }
                clientsListbox.DataSource = null;

                clientsListbox.DataSource = clients.Where(clie => clie.Name.Contains(clientName)).ToList();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        //if empty or null search text than shows all IE
        private void FilterClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filterClient.Text))
            {
                this.DisplayClients();
            }
        }

        //form to choose a type of client to create
        private void CreateClient_Click(object sender, EventArgs e)
        {
            //ChooseClientCreate chooseClientCreateForm = new ChooseClientCreate();
            //chooseClientCreateForm.ShowDialog();
            //this.Close();

            this.manager.ChooseClientUI();
        }

        //function to compare data with database
        private bool CompareWithDb(string name, int nif)
        {
            using (var db = new Cantina())
            {
                return db.User.OfType<Student>().Any(u => u.Name == name && u.Nif == nif) ||
                       db.User.OfType<Teacher>().Any(u => u.Name == name && u.Nif == nif);
            }
        }

        //go to edit form of corresponding client type
        private void EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the listbox item is selected
                if (clientsListbox.SelectedItem != null)
                {
                    string selectedItem = clientsListbox.SelectedItem.ToString();
                    string[] dataSplit = selectedItem.Split('-');

                    if(dataSplit.Length >= 3) 
                    {
                        string name = dataSplit[0];
                        int nif = int.Parse(dataSplit[1]);
                        double balance = double.Parse(dataSplit[2]);

                        //checks client data to see if it exists in the database
                        bool existInDb = CompareWithDb(name, nif);

                        if (existInDb)
                        {
                            using (var db = new Cantina())
                            {
                                //determine if the client is a studentIE or teacherIE
                                var user = db.User.FirstOrDefault(u => u.Name == name && u.Nif == nif);

                                if (user is Student student)
                                {
                                    if (dataSplit.Length >= 4)
                                    {
                                        int numStudent = int.Parse(dataSplit[3]);
                                        EditStudent editStudentForm = new EditStudent(name, numStudent, nif, balance);
                                        editStudentForm.ShowDialog();
                                    }
                                    else
                                    {
                                        Error.Err("Insufficient data for a studentIE!");
                                    }
                                }

                                if (user is Teacher teacher)
                                {
                                    if (dataSplit.Length >= 4)
                                    {
                                        string email = dataSplit[3];
                                        EditTeacher editTeacherForm = new EditTeacher(name, email, nif, balance);
                                        editTeacherForm.ShowDialog();
                                    }
                                    else
                                    {
                                        Error.Err("Insufficient data for a teacherIE.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Error.Err("Client not found in the database!");
                        }

                    } else
                    {
                        Error.Err("Error in splint method!");
                    }
                }
                else
                {
                    Error.Err("Please select an client to edit!");
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        //delete IE from database
        private void DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClientInfo = clientsListbox.SelectedItem as ClientInfo;

                if (selectedClientInfo != null)
                {
                    using (var db = new Cantina())
                    {
                        // Find the user in the database
                        var client = db.User
                            .FirstOrDefault(u => u.Name == selectedClientInfo.Name && u.Nif == selectedClientInfo.Nif);

                        if (client != null)
                        {
                            db.User.Remove(client);
                            db.SaveChanges();
                        }
                    }

                    // Remove the client from the local list and update the ListBox
                    clientsListbox.Items.Remove(selectedClientInfo);
                }
                else
                {
                    Error.Err("Please select a client to delete!");
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }
    }
}