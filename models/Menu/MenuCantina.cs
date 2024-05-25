using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PSI_DA_PL_B.models.MenuCantina
{
    public class MenuCantina
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime data { get; set; }

        // 0 = almoco
        // 1 = jantar
        [Range(0, 1)]
        public bool tipoRefeicao {  get; set; }

        [Range(1, 10)]
        public int quantidade { get; set; }

        [Required]
        public double preco_estudante { get; set; }

        [Required]
        public double preco_professor { get; set; }

        string[] Picture { get; set; }
        string PictureUrl { get; set; }

        public MenuCantina()
        {
        }

        public MenuCantina(int quantidade, double preco_estudante, double preco_professor)
        {

            this.data = DateTime.Now;
            this.quantidade = quantidade;
            this.preco_estudante = preco_estudante;
            this.preco_professor = preco_professor;
        }
    }
}

