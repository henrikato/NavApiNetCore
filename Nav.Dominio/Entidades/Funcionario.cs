using System;

namespace Nav.Dominio.Entidades
{
    public class Funcionario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
        public Condutor Superior { get; set; }
        public long SuperiorId { get; set; }
    }
}
