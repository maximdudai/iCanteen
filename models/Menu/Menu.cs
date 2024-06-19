﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.Menu;

namespace PSI_DA_PL_B.models.MenuCantina
{
    public class MenuCanteen
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
        public decimal PrecoEstudante { get; set; }

        [Required]
        public decimal PrecoProfessor { get; set; }

        [Required]
        public virtual List<Dish> Dishes { get; set; }
        [Required]
        public virtual List<Extra> Extras { get; set; }

        public MenuCanteen()
        {

        }

        public MenuCanteen(DateTime data, int quantidade, decimal precoEstudante, decimal precoProfessor, List<Dish> dishes, List<Extra> extras)
        {
            Data = data;
            Quantidade = quantidade;
            PrecoEstudante = precoEstudante;
            PrecoProfessor = precoProfessor;
            Dishes = dishes;
            Extras = extras;
        }
    }
}

