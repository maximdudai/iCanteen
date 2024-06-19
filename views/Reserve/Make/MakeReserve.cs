using PSI_DA_PL_B.controller;
using PSI_DA_PL_B.helpers;
using PSI_DA_PL_B.models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSI_DA_PL_B.views.Clients.Both.ListClients;

namespace PSI_DA_PL_B.views.Reserve.Make
{
    public partial class MakeReserve : Form
    {
        private Manager manager { get; set; }
        private int nif;
        private string typeClient;
        public MakeReserve()
        {
            InitializeComponent();
        }

        public MakeReserve(int nif, string typeClient, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
            this.typeClient = typeClient;
            LoadClient();
        }

        /***TODO***
        - Para cada entidade deverá ser efetuado o CRUD, e apresentada uma lista dos registos;
        - Na realização de uma reserva deverá:
            - ser escolhido cliente [alterar]
                    - tabela na base de dados com todos os clientes que foram almoçar/jantar pelo menos uma vez a cantina, se ele não estiver na base de dados, o funcionário pode ou não adiciona-lo.
            - ser escolhido o prato e os extras disponíveis no menu selecionado
            - Ao preço do Menu de cada Cliente deverá ser somado o preço de cada Extra escolhido
            - apenas poderá efetuar uma reserva de um Prato por dia e de três Extra no máximo
            - não poderá escolher pratos ou extras sem quantidade disponível
        No fim:
            - caso a reserva seja feita no período já considerado de multa, a respetiva multa deverá ser registada
            - para cada Reserva feita deverá ser decrementada a quantidade disponível e o valor do saldo do Cliente
            - deverá ser emitido um talão gravado num ficheiro de texto com informação do cliente e do menu (dia/hora, prato e extras)  [pode-se colocar saldo cativo]
        **********/

        private void LoadClient()
        {
            try
            {
                using (var db = new Cantina())
                {
                    if (this.typeClient == "Estudante")
                    {
                        var nifStudentReceived = db.User
                        .OfType<Student>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                        if (nifStudentReceived != null)
                        {
                            typeClientLabel.Text = "Estudante";
                            nifLabel.Text = nifStudentReceived.Nif.ToString();
                            balanceLabel.Text = nifStudentReceived.Balance.ToString();
                        }
                    }

                    if (this.typeClient == "Professor")
                    {
                        var nifTeacherReceived = db.User
                        .OfType<Teacher>()
                        .FirstOrDefault(u => u.Nif == this.nif);

                        if (nifTeacherReceived != null)
                        {
                            typeClientLabel.Text = "Professor";
                            nifLabel.Text = nifTeacherReceived.Nif.ToString();
                            balanceLabel.Text = nifTeacherReceived.Balance.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error.Err(ex.Message);
            }
        }

        private void MakeReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }
    }
}
