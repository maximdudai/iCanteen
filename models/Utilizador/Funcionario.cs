using System;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.models.Utilizador
{
    internal class Funcionario : Utilizador
    {
        public string username { get; set; }

        public Funcionario(string nome, int nif, string username) : base(nome, nif)
        {
            this.username = username;
        }
    }
}
