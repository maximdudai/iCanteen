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

namespace PSI_DA_PL_B.views.Menu.MenuList.Create
{
    public partial class CreateMenu : Form
    {
        Manager manager { get; set;}

        DateTime date { get; set; }
        DateTime fromTime { get; set; }
        DateTime toTime { get; set; }

        private decimal priceStudent { get; set; }
        private decimal priceTeacher { get; set; }

        List<models.Menu.Extra> AvailableExtra { get; set; }
        List<models.Menu.Dish> AvailableDish { get; set; }

        public CreateMenu(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            List<models.Menu.Extra> AvailableExtra = new List<models.Menu.Extra>();
            List<models.Menu.Dish> AvailableDish = new List<models.Menu.Dish>();

            this.LoadDataFromDatabase();
        }

        private void createMenuList_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataFromDatabase()
        {
            using(var db = new Cantina())
            {
                // Get all available extras and dished and store them in the respective lists

                this.AvailableExtra = db.Extra.ToList();
                this.AvailableDish = db.Dish.ToList();
            }
        }
    }
}
