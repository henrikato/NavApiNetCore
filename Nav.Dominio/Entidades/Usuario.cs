using System;
namespace Nav.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public Usuario Responsavel { get; set; }
        public Usuario Condutor { get; set; }
    }
}
