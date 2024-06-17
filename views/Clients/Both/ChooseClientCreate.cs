using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.views.Clients.Students.Create;
using PSI_DA_PL_B.views.Clients.Teachers.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Clients.Both
{
    public partial class ChooseClientCreate : Form
    {
        private Manager manager { get; set; }
        public ChooseClientCreate()
        {
            InitializeComponent();
        }

        public ChooseClientCreate (Manager manager) : this()
        {
            this.manager = manager;
        }

        private void StudentCreate_Click(object sender, EventArgs e)
        {
            this.manager.CreateStudentUI();
        }

        private void TeacherCreate_Click(object sender, EventArgs e)
        {
            this.manager.CreateTeacherUI();
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ClientListUI();
        }
    }
}
