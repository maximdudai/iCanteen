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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PSI_DA_PL_B.views.Clients.Both
{
    public partial class ListClients : Form
    {
        private readonly List<Client> clients;

        //to join the queries
        public class ClientInfo
        {
            public string Name { get; set; }
            public int Nif { get; set; }
            public double Balance { get; set; }
            public int? NumStudent { get; set; }
            public string Email { get; set; }
        }

        public ListClients()
        {
            InitializeComponent();
            clients = new List<Client>();
            LoadClients();
        }

        private void LoadClients()
        {
            try
            {
                using (var db = new Cantina())
                {                    
                    //query for students
                    var studentList = db.User
                        .OfType<Student>()
                        .Select(u => new ClientInfo
                        {
                            Name = u.Name,
                            Nif = u.Nif,
                            Balance = u.Balance,
                            NumStudent = u.NumStudent//,
                            //Email = null
                        }).ToList();

                    foreach (var stu in studentList)
                    {
                        Student student = new Student((string)stu.Name, (int)stu.Nif, (double)stu.Balance, (int)stu.NumStudent);
                        clients.Add(student);

                        //Client client = new Client((string)clie.Name, (int)clie.Nif, (double)clie.Balance);
                        //clients.Add(client);
                    }

                    //query for teachers
                    var teacherList = db.User
                        .OfType<Teacher>()
                        .Select(u => new ClientInfo
                        {
                            Name = u.Name,
                            Nif = u.Nif,
                            Balance = u.Balance,
                            //NumStudent = null,
                            Email = u.Email
                        }).ToList();

                    foreach (var tea in teacherList)
                    {
                        Teacher teacher = new Teacher((string)tea.Name, (int)tea.Nif, (double)tea.Balance, (string)tea.Email);
                        clients.Add(teacher);
                    }

                    /*
                    //combine studentList with teacherList
                    var clientList = studentList.Concat(teacherList).ToList();

                    foreach (var clie in clientList)
                    {
                        Client client = new Client((string)clie.Name, (int)clie.Nif, (double)clie.Balance);
                        clients.Add(client);
                    }
                    */
                    /*
                    var studentList = dbClients.User
                    .OfType<Student>()
                    .Select(u => new Student
                    {
                        Name = u.Name,
                        Nif = u.Nif,
                        Balance = u.Balance,
                        NumStudent = u.NumStudent
                    }).ToList();

                        // Query for teachers
                        var teacherList = dbClients.User
                            .OfType<Teacher>()
                            .Select(u => new Teacher
                            {
                                Name = u.Name,
                                Nif = u.Nif,
                                Balance = u.Balance,
                                Email = u.Email
                            }).ToList();

                    clients.AddRange(studentList);
                    clients.AddRange(teacherList);
                    */
                }        

            this.DisplayClients();           
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        //receiving a list as a parameter
        private void DisplayClients()
        {
            clientsList.DataSource = null;
            clientsList.DataSource = clients;
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
                clientsList.DataSource = null;

                clientsList.DataSource = clients.Where(clie => clie.Name.Contains(clientName)).ToList();
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        //if empty or null search text than shows all clients
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
            ChooseClientCreate chooseClientCreateForm = new ChooseClientCreate();
            chooseClientCreateForm.ShowDialog();
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
                if (clientsList.SelectedItem != null)
                {
                    string selectedItem = clientsList.SelectedItem.ToString();
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
                                //determine if the client is a student or teacher
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
                                        Error.Err("Insufficient data for a student!");
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
                                        Error.Err("Insufficient data for a teacher.");
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

        //delete clients from database
        private void DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = clientsList.SelectedItem as Client;

                if (selectedClient != null)
                {
                    using (var db = new Cantina())
                    {
                        var client = db.User
                            .OfType<Client>()
                            .Where(u => u.Name == selectedClient.Name)
                            .FirstOrDefault();

                        if (client != null)
                        {
                            db.User.Remove(client);
                            db.SaveChanges();
                        }
                    }

                    clients.Remove(selectedClient);
                    this.DisplayClients();
                }
                else
                {
                    Error.Err("Please select an employee to delete!");
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }
    }
}