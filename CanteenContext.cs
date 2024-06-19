using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.User;
using PSI_DA_PL_B.models.MenuCantina;
using PSI_DA_PL_B.models.Menu;
using System.Reflection.Emit;

namespace PSI_DA_PL_B
{
    public class Cantina : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<MenuCanteen> MenuCantina { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Extra> Extra { get; set; }
    }
}
