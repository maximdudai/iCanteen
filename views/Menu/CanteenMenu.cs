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
using PSI_DA_PL_B.views.Menu.TicketMenu;

namespace PSI_DA_PL_B.views.Menu
{
    public partial class CanteenMenu : Form
    {
        private string username { get; set; }
        private string name { get; set; }

        private Timer timer;
        private Manager manager { get; set; }

        private int currentWeek { get; set; }
        CultureInfo cultureInfo;
        Calendar calendar;
        CalendarWeekRule weekRule;
        DayOfWeek firstDayOfWeek;

        private int NEXT_WEEK = 2;
        private int PREVIOUS_WEEK = 1;
        private int CURRENT_WEEK_VIEW { get; set; } = 0;

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
            
            this.cultureInfo = new CultureInfo("pt-PT");
            this.calendar = cultureInfo.Calendar;
            this.weekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            this.firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

            this.CURRENT_WEEK_VIEW = this.GetCurrentYearWeek();

            this.GetMenuCurrentWeek();

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
            this.manager.EmployeeListUI();

            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.manager.LoginUI();

            this.Close();
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            TicketMenu.TicketMenu ticket = new TicketMenu.TicketMenu();
            ticket.ShowDialog();
        }

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

            int week = GetCurrentYearWeek();

            if (operation == this.PREVIOUS_WEEK)
            {
                // if the current week is the first week of the year, set the week to the last week of the year
                if(this.currentWeek <= this.GetMinWeeksOfYear())
                {
                    this.CURRENT_WEEK_VIEW = this.GetMaxWeeksOfYear();
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
                if(this.currentWeek >= this.GetMaxWeeksOfYear())
                {
                    this.CURRENT_WEEK_VIEW = this.GetMinWeeksOfYear();
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

        private int GetCurrentYearWeek()
        {
            int currentWeekNumber = calendar.GetWeekOfYear(DateTime.Now, this.weekRule, this.firstDayOfWeek);

            return currentWeekNumber;
        }
        private int GetMaxWeeksOfYear()
        {
            int maxWeeks = calendar.GetWeekOfYear(new DateTime(DateTime.Now.Year, 12, 31), this.weekRule, this.firstDayOfWeek);

            return maxWeeks;
        }

        private int GetMinWeeksOfYear()
        {
            int minWeeks = calendar.GetWeekOfYear(new DateTime(DateTime.Now.Year, 1, 1), this.weekRule, this.firstDayOfWeek);

            return minWeeks;
        }

        private void UpdateWeekUI()
        {
            this.currentWeekLabel.Text = this.currentWeek.ToString();

            string dailyMenu = this.currentWeek == this.GetCurrentYearWeek() ? $"Menus Diários da Semana Atual" : $"Menus Diários da Semana #{this.currentWeek}";
            this.dailyMenuWeek.Text = dailyMenu;
        }

    }
}
