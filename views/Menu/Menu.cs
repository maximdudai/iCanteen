using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.Utilizador;

namespace PSI_DA_PL_B.views.Menu
{
    public partial class Menu : Form
    {
        private string username { get; set; }
        private string name { get; set; }
        private Timer timer;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string username) : this()
        {
            this.username = this.labelUsername.Text = username;

            this.LoadData();
            this.UpdateUserUI();

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
                    var currentUser = db.Utilizador.
                        OfType<Funcionario>()
                        .Where(user => user.Username == this.username)
                        .Select(user => new
                        {
                            user.Nome,
                        })
                        .FirstOrDefault();

                    this.name = currentUser.Nome;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
