using PSI_DA_PL_B.models.Menu;
using PSI_DA_PL_B.models.MenuCantina;
using PSI_DA_PL_B.models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSI_DA_PL_B.models.Reserve
{
    public class ReserveCanteen
    {
        [Key]
        public int ReserveId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReserveDate { get; set; }

        [Required]
        public virtual List<Client> Clients { get; set; }

        [Required]
        public virtual List<MenuCanteen> Menus { get; set; }

        [Required]
        public virtual List<Dish> Dishes { get; set; }

        [Required]
        public virtual List<Extra> Extras { get; set; }

        [Required] 
        public virtual List<Ticket> Tickets { get; set; }

        [Required]
        public string Status { get; set; } // Pendente, Concluida, Cancelada

        public ReserveCanteen()
        {
        }

        public ReserveCanteen(DateTime reserveDate, List<Client> clients, List<MenuCanteen> menus, List<Dish> dishes, List<Extra> extras, List<Ticket> tickets, string status)
        {
            this.ReserveDate = reserveDate;
            this.Clients = clients;
            this.Menus = menus;
            this.Dishes = dishes;
            this.Extras = extras;
            this.Tickets = tickets;
            this.Status = status;
        }
    }
}