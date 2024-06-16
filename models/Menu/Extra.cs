using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Range(0, 1)]
        public bool Ativo { get; set; }

        public Extra() : base()
        {
        }

        public Extra(string descricao, bool ativo)
        {
            this.Descricao = descricao;
            this.Ativo = ativo;
        }
    }
}
