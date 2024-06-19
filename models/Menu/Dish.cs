using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PSI_DA_PL_B.models.MenuCantina;

namespace PSI_DA_PL_B.models.Menu
{
    public class Dish
    {
        [Key]
        public int itemId { get; set; }

        [MaxLength(144)]
        public string Description { get; set; }

        // Tipo: Prato, Bebida, Sobremesa
        [Required]
        public string Type { get; set; }

        [Range(0, 1)]
        public bool Active { get; set; }
        public Dish() : base()
        {
        }

        public Dish(string description, string type, bool active)
        {
            this.Description = description;
            this.Type = type;
            this.Active = active;
        }

        public override string ToString()
        {
            return this.Type;
        }
    }
}
