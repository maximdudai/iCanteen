using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSI_DA_PL_B.models.MenuCantina;


namespace PSI_DA_PL_B.models.Menu
{
    public class Extra : MenuCantina.Menu
    {
        [Key]
        public int itemId { get; set; }

        [MaxLength(256)]
        public string Descricao { get; set; }

        [Range(0, 1)]
        public bool Ativo { get; set; }

        string[] Picture { get; set; }
        string PictureUrl { get; set; }

        public Extra() : base()
        {
        }

        public Extra(int quantidade, double preco_estudante, double preco_professor, string descricao, bool ativo)
            : base(quantidade, preco_estudante, preco_professor)
        {
            this.Descricao = descricao;
            this.Ativo = ativo;
        }
    }
}
