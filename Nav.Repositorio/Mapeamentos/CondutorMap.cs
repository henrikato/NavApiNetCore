using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nav.Dominio.Entidades;

namespace Nav.Repositorio.Mapeamentos
{
    public class CondutorMap : IEntityTypeConfiguration<Condutor>
    {
        public void Configure(EntityTypeBuilder<Condutor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Registro).HasMaxLength(20).IsRequired();
            builder.Property(x => x.NumeroTelefone).HasMaxLength(11).IsRequired();
            builder.HasMany(x => x.Funcionarios).WithOne(x => x.Superior);
            builder.HasMany(x => x.FluxoCaixa).WithOne(x => x.Condutor).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
