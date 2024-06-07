using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B;

namespace PSI_DA_PL_B.models.User
{
    internal class Employee : User
    {
        public string Username { get; set; }

        public Employee() : base() { }

        public Employee(string name, int nif, string username) : base(name, nif)
        {
            this.Username = username;
        }
        
        public override string ToString()
        {
            return $"{this.Username} - {Nif}";
        }
    }
}
