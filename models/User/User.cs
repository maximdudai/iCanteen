using System;
using System.ComponentModel.DataAnnotations;

namespace PSI_DA_PL_B.models.User
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [Range(100000000, 999999999, ErrorMessage = "NIF must be a 9-digit number")]
        public int Nif { get; set; }

        string[] Picture { get; set; }
        string PictureUrl { get; set; }

        public User()
        {
        }

        public User(string name, int nif)
        {
            this.Name = name;
            this.Nif = nif;
        }
    }
}
