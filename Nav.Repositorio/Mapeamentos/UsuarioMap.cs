using System.Data.Entity.ModelConfiguration;
using Nav.Dominio.Entidades;

namespace Nav.Repositorio.Mapeamentos
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(20).IsRequired();
            Property(x => x.Sobrenome).HasMaxLength(20).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.NumeroTelefone).HasMaxLength(11).IsRequired();
            Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            Property(x => x.DataNascimento).IsRequired();
        }
    }
}
