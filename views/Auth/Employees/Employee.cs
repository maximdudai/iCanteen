using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI_DA_PL_B.models.Utilizador;

namespace PSI_DA_PL_B.views.Auth.Employees
{
    public partial class Employee : Form
    {
        private List<Funcionario> funcionarios;
        public Employee()
        {
            InitializeComponent();
            funcionarios = new List<Funcionario>();
        }
    }
}
