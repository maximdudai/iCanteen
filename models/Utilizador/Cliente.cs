using System;

namespace PSI_DA_PL_B.models.Utilizador
{
    internal class Cliente : Utilizador
    {
        public double Saldo { get; set; }

        public Cliente() : base()
        {
        }

        public Cliente(string nome, int nif, double saldo)
            : base(nome, nif)
        {
            this.Saldo = saldo;
        }
    }
}
