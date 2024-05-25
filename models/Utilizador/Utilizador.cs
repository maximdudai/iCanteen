﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PSI_DA_PL_B.models.Utilizador
{
    public class Utilizador
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Nome { get; set; }

        [Range(100000000, 999999999, ErrorMessage = "NIF must be a 9-digit number")]
        public int Nif { get; set; }

        //Funcionario - 1, Cliente - 2, Professor - 3, Estudante - 4
        [Range(1, 4)]
        public int funcId { get; set; }

        string[] Picture { get; set; }
        string PictureUrl { get; set; }

        public Utilizador()
        {
        }

        public Utilizador(string nome, int nif)
        {
            this.Nome = nome;
            this.Nif = nif;
        }
    }
}
