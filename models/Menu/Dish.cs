using System;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.MenuCantina;

namespace PSI_DA_PL_B.models.Menu
{
    public class Dish : MenuCantina.Menu
    {
        [Key]
        public int itemId { get; set; }

        [MaxLength(144)]
        public string Descricao { get; set; }

        [Range(1, 3)]
        public int Tipo { get; set; }

        [Range(0, 1)]
        public bool Ativo { get; set; }

        string[] Picture { get; set; }
        string PictureUrl { get; set; }

        public Dish() : base()
        {
        }

        public Dish(int quantidade, double preco_estudante, double preco_professor, string descricao, int tipo, bool ativo)
            : base(quantidade, preco_estudante, preco_professor)
        {
            this.Descricao = descricao;
            this.Tipo = tipo;
            this.Ativo = ativo;
        }
    }
}
