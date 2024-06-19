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

namespace PSI_DA_PL_B.views.Reserve.Confirm
{
    public partial class ConfirmReserve : Form
    {
        private Manager manager { get; set; }
        private int nif;
        public ConfirmReserve()
        {
            InitializeComponent();
        }

        public ConfirmReserve(int nif, Manager manager) : this()
        {
            this.manager = manager;
            this.nif = nif;
        }

        /***TODO***
        - Apresentar todas as reservas efetuadas e permitir marcar uma delas como utilizada
        - Após a marcação da Reserva como utilizada:
            - Deverá ser criada uma Fatura com os Itens do Menu, o total e gravada num ficheiro em formato PDF
            - Não deverá permitir utilizar novamente essa reserva
        **********/

        private void ConfirmReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manager.ChooseTabReserveUI();
        }
    }
}
