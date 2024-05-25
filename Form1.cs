using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B;
using PSI_DA_PL_B.models.Utilizador;
using PSI_DA_PL_B.models.MenuCantina;


namespace PSI_DA_PL_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // exemplo codigo para guardar na base de dados.
            using (var db = new Cantina())
            {
                var utilizador = new Utilizador { Nome = "Joao", Nif = 123321123 };
                db.Utilizador.Add(utilizador);
                db.SaveChanges();

                var menu = new MenuCantina { data = DateTime.Now, quantidade = 10, preco_estudante = 2.5, preco_professor = 3.5 };
                db.MenuCantina.Add(menu);
                db.SaveChanges();
            }
        }
    }
}
