using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;

namespace PSI_DA_PL_B.views.Menu.MenuList
{
    public partial class MenuList : Form
    {
        Manager manager { get; set; }
        private Week weekData { get; }
        private int currentWeek { get; set; }
        private int CURRENT_WEEK_VIEW { get; set; }
        private int NEXT_WEEK = 2;
        private int PREVIOUS_WEEK = 1;



        public MenuList(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            this.weekData = new Week();
            this.CURRENT_WEEK_VIEW = this.weekData.GetCurrentYearWeek();
            this.GetMenuCurrentWeek();
        }

        private void menuNextWeek_Click(object sender, EventArgs e)
        {
            this.GetMenuCurrentWeek(this.NEXT_WEEK);
        }

        private void menuPrevWeek_Click(object sender, EventArgs e)
        {
            this.GetMenuCurrentWeek(this.PREVIOUS_WEEK);
        }

        private void GetMenuCurrentWeek(int operation = 0)
        {

            // operation 0 = no operation
            // operation 1 = previous week
            // operation 2 = next week

            int week = weekData.GetCurrentYearWeek();

            Console.WriteLine("Current Week: " + currentWeek);

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

            this.UpdateMenuUI();
        }
        private void UpdateWeekUI()
        {
            this.currentWeekLabel.Text = this.currentWeek.ToString();
        }

        public void UpdateMenuUI()
        {
            // get radio button selected

        }

        private void createNewMenu_Click(object sender, EventArgs e)
        {
            this.manager.ShowCreateMenuUI();
        }
    }
}
