using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.models.Menu
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Ticket hour must be a number between 1 and 10.")]
        public int hours { get; set; }

        [Required]
        [Range(0.1, 10, ErrorMessage = "Ticket value must be a number between 0.1 and 10.")]
        public double value { get; set; }

        public Ticket()
        {
        }

        public Ticket(int hours, double value)
        {
            this.hours = hours;
            this.value = value;
        }

        public override string ToString()
        {
            return $"Tempo: {hours}h - Valor: {value}€";
        }
    }

}
