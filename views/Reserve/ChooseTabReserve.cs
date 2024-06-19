using PSI_DA_PL_B.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Reserve
{
    public partial class ChooseTabReserve : Form
    {
        private Manager manager { get; set; }
        public ChooseTabReserve()
        {
            InitializeComponent();
        }
        public ChooseTabReserve(Manager manager) : this()
        {
            this.manager = manager;
        }

        private void ChooseMakeReserve_Click(object sender, EventArgs e)
        {
            
            this.manager.SelectClientReserveUI();
        }

        private void ChooseConfirmeReserve_Click(object sender, EventArgs e)
        {
            this.manager.SelectClientUI("confirmReserve");
        }

        private void ChooseTabReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }
    }
}
