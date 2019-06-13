using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nav.Dominio.Entidades;

namespace Nav.Repositorio.Mapeamentos
{
    public class ResponsavelMap : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.NumeroTelefone).HasMaxLength(11).IsRequired();
            builder.HasMany(x => x.Dependentes).WithOne(x => x.Responsavel).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
