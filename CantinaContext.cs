using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.Utilizador;
using PSI_DA_PL_B.models.MenuCantina;

using System.Reflection.Emit;

namespace PSI_DA_PL_B
{
    public class Cantina : DbContext
    {
        public DbSet<Utilizador> Utilizador { get; set; }
        public DbSet<MenuCantina> MenuCantina { get; set; }

        // Optional: Configure the connection string
    }
}
