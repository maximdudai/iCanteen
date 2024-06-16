using System;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.MenuCantina;

namespace PSI_DA_PL_B.models.Menu
{
    public class Dish
    {
        [Key]
        public int itemId { get; set; }

        [MaxLength(144)]
        public string Descricao { get; set; }

        // Tipo: Prato, Bebida, Sobremesa
        [Required]
        public string Tipo { get; set; }

        [Range(0, 1)]
        public bool Ativo { get; set; }

        public Dish() : base()
        {
        }

        public Dish(string descricao, string tipo, bool ativo)
        {
            this.Descricao = descricao;
            this.Tipo = tipo;
            this.Ativo = ativo;
        }

        public override string ToString()
        {
            return this.Tipo;
        }
    }
}
