using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;

namespace PSI_DA_PL_B.views
{
    public partial class AtribuirEscritorio : Form
    {
        Manager manager;
        List<models.User.User> listClients {  get; set; }
        List<Escritorio> listEscritorio { get; set; }
        public AtribuirEscritorio(Manager manager)
        {
            InitializeComponent();

            this.manager = manager;

            listClients = new List<models.User.User>();
            listEscritorio = new List<Escritorio>();


            this.LoadEscritorios();
            this.LoadClients();
        }

        private void LoadEscritorios()
        {
            using (var db = new Cantina())
            {
                var escList = db.Escritorios.ToList();

                foreach (var emp in escList)
                {
                    Escritorio escritorio = new Escritorio(emp.Localizacao, emp.Cacifo);
                    listEscritorio.Add(escritorio);
                }
            }
            totalEscritorios.DataSource = null;
            totalEscritorios.DataSource = listEscritorio;
        }

        private void LoadClients()
        {
            using (var db = new Cantina())
            {
                var allClients = db.User
                    .Where(e => e.escritorio_id == 0)
                    .Select(data => new
                    {
                        data.Name,
                        data.escritorio_id
                    })
                    .ToList();

                foreach(var client in allClients)
                {
                    models.User.User availableUser = new models.User.User(client.Name, 0, client.escritorio_id);
                    listClients.Add(availableUser);
                }
            }

        }

        private void addEscritorio_Click(object sender, EventArgs e)
        {
            var selectedEscritorio = this.totalEscritorios.SelectedItem as Escritorio;
            var selectedUser = this.totalUsers.SelectedItem as models.User.User;

            using(var db = new Cantina())
            {
                var clientData = db.User
                    .Where(data => data.Id == selectedUser.Id)
                    .FirstOrDefault();

                clientData.escritorio_id = selectedEscritorio.Id;
                db.SaveChanges();
            }

            listClients.Remove(selectedUser);

            totalUsers.DataSource = null;
            totalUsers.DataSource = listClients;

            //increase total_users
            using(var dbData = new Cantina())
            {
                var escData = dbData.Escritorios
                    .Where(dt => dt.Id == selectedEscritorio.Id)
                    .FirstOrDefault();
                escData.total_users++;

                dbData.SaveChanges();
            }
        }

        private void AtribuirEscritorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.MainMenuUI();
        }
    }
}
