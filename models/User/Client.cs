using System;

namespace PSI_DA_PL_B.models.User
{
    internal class Client : User
    {
        public double Balance { get; set; }
        public double BalanceCativo { get; set; }

        public Client() : base() { }

        public Client(string name, int nif) : base(name, nif)
        {
            this.Balance = 0;
            this.BalanceCativo = 0;
        }
    }
}