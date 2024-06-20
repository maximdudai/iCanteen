using System;
using System.ComponentModel.DataAnnotations;

namespace PSI_DA_PL_B.models.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [Range(100000000, 999999999, ErrorMessage = "NIF must be a 9-digit number")]
        public int Nif { get; set; }

        string[] Picture { get; set; }
        string PictureUrl { get; set; }

        [MaxLength(256)]
        private string Tema { get; }

        public int escritorio_id { get; set; }

        public User()
        {
        }

        public User(string name, int nif, int escritorio_id = 0)
        {
            this.Name = name;
            this.Nif = nif;
            this.Tema = "Defesa Projeto DA - 2023/24";
            this.escritorio_id = escritorio_id;
        }

        public override string ToString()
        {
            return this.Name + " " + this.escritorio_id;
        }
    }
}
