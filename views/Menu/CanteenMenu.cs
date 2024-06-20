using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private Week weekData { get; }
        private int currentWeek { get; set; }
        private int CURRENT_WEEK_VIEW { get; set; }
        private int NEXT_WEEK = 2;
        private int PREVIOUS_WEEK = 1;

        List<Escritorio> Escritorios { get; set; }

        public CanteenMenu()
        {
            InitializeComponent();
        }
        public CanteenMenu(Manager manager, string username) : this()
        {
            this.manager = manager;
            this.username = this.manager.username = username;

            this.LoadData();
            this.UpdateUserUI();

            this.weekData = new Week();
            this.CURRENT_WEEK_VIEW = this.weekData.GetCurrentYearWeek();
            this.GetMenuCurrentWeek();

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(UpdateCurrentDateTime);

            this.Escritorios = new List<Escritorio>();
            this.LoadEscritorios();
        }

        private void UpdateCurrentDateTime(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.currentDateTime.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer.Start();
        }


        #region Employee
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

                    // If somehow the user is not found, redirect to login
                    if (currentUser != null)
                        this.name = currentUser.Name;
                    else
                        this.manager.LoginUI();
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
        private void changeEmployee_Click(object sender, EventArgs e)
        {
            this.manager.EmployeeListUI();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.manager.LoginUI();
        }
        #endregion

        #region Main buttons
        private void clientbutton_Click(object sender, EventArgs e)
        {
            this.manager.ClientListUI();
        }

        //MenuButton

        private void dishButton_Click(object sender, EventArgs e)
        {
            this.manager.ShowDishListUI();
        }

        private void extraButton_Click(object sender, EventArgs e)
        {
            this.manager.ShowExtraListUI();
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            TicketMenu.TicketMenu ticket = new TicketMenu.TicketMenu();
            ticket.ShowDialog();
        }

        //ReserveButton
        private void reserveButton_Click(object sender, EventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }
        private void balanceButton_Click(object sender, EventArgs e)
        {
            this.manager.SelectClientUI("balance");
        }
        #endregion

        #region Show weekly menu
        private void menuPrevWeek_Click(object sender, EventArgs e)
        {
            GetMenuCurrentWeek(this.PREVIOUS_WEEK);
        }
        private void menuNextWeek_Click(object sender, EventArgs e)
        {
            GetMenuCurrentWeek(this.NEXT_WEEK);
        }
        private void GetMenuCurrentWeek(int operation = 0)
        {

            // operation 0 = no operation
            // operation 1 = previous week
            // operation 2 = next week

            int week = weekData.GetCurrentYearWeek();

            if (operation == this.PREVIOUS_WEEK)
            {
                // if the current week is the first week of the year, set the week to the last week of the year
                if (this.currentWeek <= this.weekData.GetMinWeeksOfYear())
                {
                    this.CURRENT_WEEK_VIEW = this.weekData.GetMaxWeeksOfYear();
                }
                else
                {
                    this.CURRENT_WEEK_VIEW--;
                }

                week = this.CURRENT_WEEK_VIEW;
            }
            else if (operation == this.NEXT_WEEK)
            {
                // if the current week is the last week of the year, set the week to the first week of the year
                if (this.currentWeek >= this.weekData.GetMaxWeeksOfYear())
                {
                    this.CURRENT_WEEK_VIEW = this.weekData.GetMinWeeksOfYear();
                }
                else
                {
                    this.CURRENT_WEEK_VIEW++;
                }

                week = this.CURRENT_WEEK_VIEW;
            }

            this.currentWeek = CURRENT_WEEK_VIEW;

            this.UpdateWeekUI();
        }


        private void UpdateWeekUI()
        {
            this.currentWeekLabel.Text = this.currentWeek.ToString();

            string dailyMenu = this.currentWeek == this.weekData.GetCurrentYearWeek() ? $"Menus Diários da Semana Atual" : $"Menus Diários da Semana #{this.currentWeek}";
            this.dailyMenuWeek.Text = dailyMenu;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.manager.ShowMenuListUI();
        }
        #endregion

        private void escritoriosButton_Click(object sender, EventArgs e)
        {
            this.manager.ShowAtribuirEscritorio();
        }

        private void criarEscritorio_Click(object sender, EventArgs e)
        {
            this.manager.ShowCriarEscritorio();
        }

        private void LoadEscritorios()
        {
            using (var db = new Cantina())
            {
                var fromDB = db.Escritorios.ToList();

                foreach(var item in fromDB)
                {
                    Escritorio escShow = new Escritorio(item.Localizacao, item.Cacifo, true);
                    this.Escritorios.Add(escShow);
                }
            }
            this.totalUsed.DataSource = null;
            this.totalUsed.DataSource = this.Escritorios;
        }
    }
}