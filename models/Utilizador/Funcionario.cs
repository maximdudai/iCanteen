using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PSI_DA_PL_B.models.Utilizador;
using PSI_DA_PL_B;

namespace PSI_DA_PL_B.models.Utilizador
{
    internal class Funcionario : Utilizador
    {
        public new string Username { get; set; }

        public Funcionario() : base() { }

        public Funcionario(string nome, int nif, string username) : base(nome, nif)
        {
            this.Username = username;
        }
        
        public override string ToString()
        {
            return $"{Username} - {Nif}";
        }
    }
}
