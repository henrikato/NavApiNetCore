using System;
using System.Collections.Generic;

namespace Nav.Dominio.Entidades
{
    public class Condutor : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
        public string Registro { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<ItemCaixa> FluxoCaixa { get; set; }
    }
}
