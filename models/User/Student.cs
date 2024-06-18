using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.models.User
{
    internal class Student : Client
    {
        public int NumStudent { get; set; }

        public Student() : base() { }

        public Student(string name, int nif, decimal balance, int numStudent) : base(name, nif)
        {
            this.NumStudent = numStudent;
        }
    }
}