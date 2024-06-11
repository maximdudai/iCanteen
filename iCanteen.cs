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

namespace PSI_DA_PL_B
{
    public partial class iCanteen : Form
    {
        private Timer timer;

        public iCanteen()
        {
            InitializeComponent();

            timer = new Timer();

            // Set the timer interval between 1 and 2 seconds
            timer.Interval = new Random().Next(2001, 3001);

            timer.Tick += new EventHandler(HandleLoginForm);
        }
        private void iCanteen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void HandleLoginForm(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();

            Manager manager = new Manager();
            manager.LoginUI(true);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Clean up the timer
            if (timer != null)
            {
                timer.Dispose();
            }
            base.OnFormClosed(e);
        }
    }
}
