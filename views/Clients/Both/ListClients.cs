using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            NumStudent = u.NumStudent,
                            Email = null
                        });

                    //query for teachers
                    var teacherList = db.User
                        .OfType<Teacher>()
                        .Select(u => new ClientInfo
                        {
                            Name = u.Name,
                            Nif = u.Nif,
                            Balance = u.Balance,
                            NumStudent = null,
                            Email = u.Email
                        });

                    //combine studentList with teacherList
                    var clientList = studentList.Concat(teacherList).ToList();

                    foreach (var clie in clientList)
                    {
                        Client client = new Client((string)clie.Name, (int)clie.Nif, (double)clie.Balance);
                        clients.Add(client);
                    }
                }                             

            this.DisplayClients();           
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        // receiving a list as a parameter
        private void DisplayClients()
        {
            clientsList.DataSource = null;
            clientsList.DataSource = clients;
        }

        //search by client name
        private void searchClient_Click(object sender, EventArgs e)
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

                //clientsList.DataSource = clients.Where(clie => clie.Name.Contains(clientName).ToList());
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        //if empty or null search text than shows all clients
        private void filterClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filterClient.Text))
            {
                this.DisplayClients();
            }
        }

        //form to choose a type of client to create
        private void createclient_Click(object sender, EventArgs e)
        {
            ChooseClientCreate chooseClientCreateForm = new ChooseClientCreate();
            chooseClientCreateForm.ShowDialog();
            //this.Close();
        }
    }
}
