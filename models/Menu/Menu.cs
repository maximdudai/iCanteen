using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.Menu;

namespace PSI_DA_PL_B.models.MenuCantina
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        // 0 = almoco, 1 = jantar
        [Range(0, 1)]
        public int TipoRefeicao { get; set; }

        [Range(1, 10)]
        public int Quantidade { get; set; }

        [Required]
        public double PrecoEstudante { get; set; }

        [Required]
        public double PrecoProfessor { get; set; }

        public virtual List<Dish> Dishes { get; set; }

        public Menu()
        {
            Dishes = new List<Dish>();
        }

        public Menu(int quantidade, double precoEstudante, double precoProfessor, List<Dish> dishes)
        {
            Data = DateTime.Now;
            Quantidade = quantidade;
            PrecoEstudante = precoEstudante;
            PrecoProfessor = precoProfessor;
            Dishes = dishes;
        }
    }
}

