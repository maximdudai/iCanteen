using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PSI_DA_PL_B.models.User
{
    internal class Student : Client
    {
        public int NumStudent { get; set; }

        public Student() : base() { }

        public Student(string name, int nif, double balance, int numStudent) : base(name, nif, balance)
        {
            this.NumStudent = numStudent;
        }

        public override string ToString()
        {
            return $"{Name} - {Nif} - {Balance} - {NumStudent}";
        }
    }
}