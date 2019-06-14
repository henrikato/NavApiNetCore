using System;
using System.ComponentModel.DataAnnotations;

namespace Nav.Dominio.Entidades
{
    public class Dependente : EntidadeBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }

        public string Cpf { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }

        public int Idade { get; set; }

        public string Detalhes { get; set; }

        public Responsavel Responsavel { get; set; }
        [Required]
        public long ResponsavelId { get; set; }
    }
}
