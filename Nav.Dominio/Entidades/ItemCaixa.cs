using System;
using System.ComponentModel.DataAnnotations;
using Nav.Dominio.ObjetoValor;

namespace Nav.Dominio.Entidades
{
    public class ItemCaixa : EntidadeBase
    {
        public Condutor Condutor { get; set; }
        [Required]
        public long CondutorId { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public CategoriaCaixa Categoria { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime DataRegistro { get; set; }
    }
}
