using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Menu.Dish
{
    public partial class Dish : Form
    {
        private List<models.Menu.Dish> dishList = new List<models.Menu.Dish>();
        public Dish()
        {
            InitializeComponent();
            this.LoadDishFromDatabase();
        }

        private void dishCreate_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDishUI()
        {
            
        }

        private void LoadDishFromDatabase()
        {
            using(var db = new Cantina())
            {
               dishList = db.Dish.ToList();
            }
            this.UpdateDishList();
        }

        private void UpdateDishList()
        {
            dishListBox.DataSource = null;
            dishListBox.DataSource = dishList;
        }
    }
}
