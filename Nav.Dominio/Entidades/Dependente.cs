using System;

namespace Nav.Dominio.Entidades
{
    public class Dependente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Detalhes { get; set; }
        public Responsavel Responsavel { get; set; }
        public long ResponsavelId { get; set; }
    }
}
