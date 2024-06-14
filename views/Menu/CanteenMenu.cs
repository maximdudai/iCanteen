using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.views.Auth.Login;
using PSI_DA_PL_B.views.Menu.Dish;
using PSI_DA_PL_B.views.Menu.TicketMenu;

namespace PSI_DA_PL_B.views.Menu
{
    public partial class CanteenMenu : Form
    {
        private string username { get; set; }
        private string name { get; set; }

        private Timer timer;
        private Manager manager { get; set; }

        public CanteenMenu()
        {
            InitializeComponent();
        }
        public CanteenMenu(Manager manager, string username) : this()
        {
            this.username = this.labelUsername.Text = username;

            this.LoadData();
            this.UpdateUserUI();

            this.manager = manager;

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(UpdateCurrentDateTime);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new Cantina())
                {
                    var currentUser = db.User.
                        OfType<Employee>()
                        .Where(user => user.Username == this.username)
                        .Select(user => new
                        {
                            user.Name,
                        })
                        .FirstOrDefault();

                    this.name = currentUser.Name;
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void UpdateUserUI()
        {
            this.userUsername.Text = this.username;
            this.userName.Text = this.name;
        }
        
        private void UpdateCurrentDateTime(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.currentDateTime.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void changeEmployee_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.EmployeeListUI();

            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.LoginUI();

            this.Close();
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            TicketMenu.TicketMenu ticket = new TicketMenu.TicketMenu();
            ticket.ShowDialog();
        }

        private void dishButton_Click(object sender, EventArgs e)
        {
            Dish.Dish dish = new Dish.Dish();
            dish.ShowDialog();
        }
    }
}
