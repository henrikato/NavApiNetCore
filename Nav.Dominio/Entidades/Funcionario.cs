using System;
using System.ComponentModel.DataAnnotations;

namespace Nav.Dominio.Entidades
{
    public class Funcionario : EntidadeBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string NumeroTelefone { get; set; }

        public Condutor Superior { get; set; }
        [Required]
        public long SuperiorId { get; set; }
    }
}
