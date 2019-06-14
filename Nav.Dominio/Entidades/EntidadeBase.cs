using System.ComponentModel.DataAnnotations;

namespace Nav.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        [Required]
        public long Id { get; set; }
    }
}
