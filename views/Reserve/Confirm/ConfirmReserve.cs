using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.models.MenuCantina;
using PSI_DA_PL_B.models.Reserve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL_B.views.Reserve.Confirm
{
    public partial class ConfirmReserve : Form
    {
        private Manager manager { get; set; }
        private int nif { get; set; }
        private string type { get; set; }

        List<ReserveCanteen> reserves = new List<ReserveCanteen>();
        List<MenuCanteen> menuCanteens = new List<MenuCanteen>();
        List<FormatMenu> displayMenu = new List<FormatMenu>();

        public ConfirmReserve()
        {
            InitializeComponent();
        }

        public ConfirmReserve(int nif, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;

            this.reserves = new List<ReserveCanteen>();
            this.menuCanteens = new List<MenuCanteen>();
            this.displayMenu = new List<FormatMenu>();

            this.LoadReserve(nif);
        }

        private void LoadReserve(int nif)
        {
            using (var context = new Cantina())
            {
                this.reserves = context.ReservaCantina.Where(r => r.clientNif == nif).ToList();
                this.menuCanteens = context.MenuCantina.ToList();


            }
        }

        private void GetMenuById(int id)
        {
            using (var context = new Cantina())
            {
                var menu = context.MenuCantina.Where(m => m.Id == id).FirstOrDefault();
                this.displayMenu.Add(new FormatMenu(menu.Id, menu.Data, menu.TipoRefeicao, menu.Quantidade, menu.PrecoEstudante, menu.PrecoProfessor, menu.Week, "Estudante"));
                this.displayMenu.Add(new FormatMenu(menu.Id, menu.Data, menu.TipoRefeicao, menu.Quantidade, menu.PrecoEstudante, menu.PrecoProfessor, menu.Week, "Professor"));
            }
        }

        private void ConfirmReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }

        private class FormatMenu
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public int TipoRefeicao { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoEstudante { get; set; }
            public decimal PrecoProfessor { get; set; }
            public int Week { get; set; }

            public string Type { get; set; }

            public FormatMenu()
            {
            }

            public FormatMenu(int id, DateTime data, int tipoRefeicao, int quantidade, decimal precoEstudante, decimal precoProfessor, int week, string type)
            {
                Id = id;
                Data = data;
                TipoRefeicao = tipoRefeicao;
                Quantidade = quantidade;
                PrecoEstudante = precoEstudante;
                PrecoProfessor = precoProfessor;
                Week = week;
                Type = type;
            }

            public override string ToString()
            {
                string type = TipoRefeicao == 0 ? "Almoço" : "Jantar";

                if (Type == "Estudante")
                {
                    return $"{Data.ToString("dd-MM-yyyy")} - {type} - Stock: {Quantidade} - {PrecoEstudante}€";
                }
                else
                {
                    return $"{Data.ToString("dd-MM-yyyy")} - {type} - Stock: {Quantidade} - {PrecoProfessor}€";
                }
            }
        }
    }
}
