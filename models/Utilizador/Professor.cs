using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.models.Utilizador
{
    internal class Professor : Cliente
    {
        public string Email {  get; set; }

        public Professor() : base()
        { }

        public Professor(string nome, int nif, double saldo, string email)
            : base(nome, nif, saldo)
        {
            this.Email = email;
        }
    }
}
