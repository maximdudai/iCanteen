using System;

namespace PSI_DA_PL_B.models.User
{
    internal abstract class Client : User
    {
        public decimal Balance { get; set; }
        public decimal BalanceCaptive { get; set;  }

        public Client() : base() { }

        public Client(string name, int nif) : base(name, nif)
        {
            this.Balance = 0.00M;
            this.BalanceCaptive = 0.00M;
        }
    }
}