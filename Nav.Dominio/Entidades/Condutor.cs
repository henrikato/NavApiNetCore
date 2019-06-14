using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nav.Dominio.Entidades
{
    public class Condutor : EntidadeBase
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
        [Required]
        public string Registro { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<ItemCaixa> FluxoCaixa { get; set; }
    }
}
