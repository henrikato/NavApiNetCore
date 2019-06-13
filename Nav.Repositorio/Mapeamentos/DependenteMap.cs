using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nav.Dominio.Entidades;

namespace Nav.Repositorio.Mapeamentos
{
    public class DependenteMap : IEntityTypeConfiguration<Dependente>
    {
        public void Configure(EntityTypeBuilder<Dependente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Idade).IsRequired();
            builder.Property(x => x.Detalhes).HasMaxLength(500);
        }
    }
}
