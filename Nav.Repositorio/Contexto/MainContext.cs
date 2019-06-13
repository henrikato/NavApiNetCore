using Microsoft.EntityFrameworkCore;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Mapeamentos;

namespace Nav.Repositorio.Contexto
{
    public class MainContext : DbContext
    {
        public DbSet<Condutor> Condutores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
        public DbSet<ItemCaixa> ItensCaixa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=NavDB;User=sa;Password=sqlServer@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemCaixaMap());

            modelBuilder.ApplyConfiguration(new CondutorMap());
            modelBuilder.Entity<Condutor>()
                .HasMany(x => x.Funcionarios)
                .WithOne(x => x.Superior)
                .HasForeignKey(x => x.SuperiorId);
            modelBuilder.Entity<Condutor>()
                .HasMany(x => x.FluxoCaixa)
                .WithOne(x => x.Condutor)
                .HasForeignKey(x => x.CondutorId);

            modelBuilder.ApplyConfiguration(new FuncionarioMap());

            modelBuilder.ApplyConfiguration(new ResponsavelMap());
            modelBuilder.Entity<Responsavel>()
                .HasMany(x => x.Dependentes)
                .WithOne(x => x.Responsavel);

            modelBuilder.ApplyConfiguration(new DependenteMap());
        }
    }
}
