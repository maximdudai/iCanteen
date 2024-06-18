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

namespace PSI_DA_PL_B.views.Menu.Balance
{
    public partial class Balance : Form
    {
        private Manager manager { get; set; }
        private int nif;
        public Balance()
        {
            InitializeComponent();
        }

        public Balance(int nif, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
        }

    }
}
