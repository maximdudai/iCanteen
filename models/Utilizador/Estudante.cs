using System;

namespace PSI_DA_PL_B.models.Utilizador
{
    internal class Estudante : Cliente
    {
        public int NumEstudante { get; set; }

        public Estudante() : base()
        {
        }

        public Estudante(string nome, int nif, double saldo, int numEstudante)
            : base(nome, nif, saldo)
        {
            this.NumEstudante = numEstudante;
        }
    }
}
