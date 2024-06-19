using PSI_DA_PL_B.helpers;
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

        public bool active { get; set; }

        public int clientNif { get; set; }

        public Ticket Ticket { get; set; }

        public int menuId { get; set; }

        public ReserveCanteen()
        {
            this.active = true;
        }

        public ReserveCanteen(int nif, Ticket ticket, int menuId)
        {
            this.clientNif = nif;
            this.Ticket = ticket;
            this.menuId = menuId;
        }

        public override string ToString()
        {
            // get client name from database

            helpers.User client = new helpers.User();
            client.GetClientNameByNif(this.clientNif);

            return $"{client} - Menu: #{menuId}";
        }
        
    }
}