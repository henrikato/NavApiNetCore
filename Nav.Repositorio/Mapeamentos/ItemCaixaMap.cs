using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nav.Dominio.Entidades;

namespace Nav.Repositorio.Mapeamentos
{
    public class ItemCaixaMap : IEntityTypeConfiguration<ItemCaixa>
    {
        public void Configure(EntityTypeBuilder<ItemCaixa> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Categoria).IsRequired();
            builder.Property(x => x.DataRegistro).IsRequired();
        }
    }
}
