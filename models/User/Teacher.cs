using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.models.User
{
    internal class Teacher : Client
    {
        public string Email {  get; set; }

        public Teacher() : base() { }

        public Teacher(string name, int nif, double balance, string email) : base(name, nif, balance)
        {
            this.Email = email;
        }
    }
}