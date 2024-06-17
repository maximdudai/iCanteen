using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees;
using PSI_DA_PL_B.views.Clients.Students.Edit;
using PSI_DA_PL_B.views.Clients.Teachers.Edit;
using PSI_DA_PL_B.views.Menu;
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
        private readonly List<ClientInfo> clients;
        private Manager manager { get; set; }

        //to join the queries
        public class ClientInfo
        {
            public string Name { get; set; }
            public int Nif { get; set; }
            public double Balance { get; set; }
            public int? NumStudent { get; set; }
            public string Email { get; set; }
    
            public ClientInfo(string name, int nif, double balance, int? numStudent, string email= null)
            {
                Name = name;
                Nif = nif;
                Balance = balance;
                NumStudent = numStudent;
                Email = email;
            }

            public override string ToString()
            {
                var text = $"Nome: {Name}; Nif: {Nif}; Balance: {Balance}";

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
            clients = new List<ClientInfo>();
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
                        (
                            u.Name,
                            u.Nif,
                            u.Balance,
                            u.NumStudent,
                            null
                        )).ToList();

                    var teacherList = db.User
                        .OfType<Teacher>()
                        .Select(u => new ClientInfo
                        (
                            u.Name,
                            u.Nif,
                            u.Balance,
                            null,
                            u.Email
                        )).ToList();

                    var clientList = studentList.Concat(teacherList).ToList();

                    
                    foreach (var all in clientList)
                    {
                        ClientInfo client = new ClientInfo(all.Name, all.Nif, all.Balance, all.NumStudent, all.Email);
                        clients.Add(client); 
                    }

                    this.DisplayClients();

                    /*
                    clientsListbox.Items.Clear();

                    foreach (var cli in clientList)
                    {
                        clientsListbox.Items.Add(cli);
                    }
                    */
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

        private void filterClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filterClient.Text))
            {
                this.DisplayClients();
            }
        }

        //form to choose a type of client to create
        private void CreateClient_Click(object sender, EventArgs e)
        {
            this.manager.ChooseClientUI();
        }

        //go to edit form of corresponding client type
        private void EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = clientsListbox.SelectedItem as ClientInfo;

                if (selectedClient != null)
                {
                    try
                    {
                        using (var db = new Cantina())
                        {
                            //check if the selected client is a student
                            var student = db.User
                                .OfType<Student>()
                                .FirstOrDefault(u => u.Nif == selectedClient.Nif);

                            if (student != null)
                            {
                                this.manager.EditStudentUI(student.Nif);
                                return;
                            }

                            //check if the selected client is a teacher
                            var teacher = db.User
                                .OfType<Teacher>()
                                .FirstOrDefault(u => u.Nif == selectedClient.Nif);

                            if (teacher != null)
                            {
                                this.manager.EditTeacherUI(teacher.Nif);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Error.Err(ex.Message);
                    }
                }
                else
                {
                    Error.Err("No client selected!");
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

        private void ListClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }       
    }
}