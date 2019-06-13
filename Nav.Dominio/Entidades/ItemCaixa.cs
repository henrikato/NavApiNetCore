using System;
using Nav.Dominio.ObjetoValor;

namespace Nav.Dominio.Entidades
{
    public class ItemCaixa : EntidadeBase
    {
        public Condutor Condutor { get; set; }
        public long CondutorId { get; set; }
        public string Descricao { get; set; }
        public CategoriaCaixa Categoria { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
