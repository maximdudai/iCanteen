using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSI_DA_PL_B.models.MenuCantina;


namespace PSI_DA_PL_B.models.Menu
{
    public class Extra
    {
        [Key]
        public int itemId { get; set; }

        [MaxLength(256)]
        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Range(0, 1)]
        public bool Ativo { get; set; }

        public Extra() : base()
        {
        }

        public Extra(string descricao, decimal preco ,bool ativo)
        {
            this.Descricao = descricao;
            this.Preco = preco;
            this.Ativo = ativo;
        }

        public override string ToString()
        {
            return this.Descricao + $" - {this.Preco}€";
        }
    }
}
