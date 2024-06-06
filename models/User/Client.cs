using System;

namespace PSI_DA_PL_B.models.User
{
    internal class Client : User
    {
        public double Balance { get; set; }

        public Client() : base()
        {
        }

        public Client(string name, int nif, double balance)
            : base(name, nif)
        {
            this.Balance = balance;
        }
        
        public override string ToString()
        {
            return $"{Name} - {Nif}";
        }      
    }
}
