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
using PSI_DA_PL_B.models.User;

namespace PSI_DA_PL_B.views
{
    public partial class CriarEscritorio : Form
    {
        Manager manager;
        public CriarEscritorio(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void CriarEscritorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }

        private void criarNovoCacifo_Click(object sender, EventArgs e)
        {
            string local = this.localName.Text;
            string cacifo = this.cacifoName.Text;

            using (var db = new Cantina())
            {
                var newEscritorio = new Escritorio(cacifo, local);
                db.Escritorios.Add(newEscritorio);
                db.SaveChanges();
            }

            this.manager.MainMenuUI();
        }
    }
}
