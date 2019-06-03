using System.Data.Entity;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Mapeamentos;

namespace Nav.Repositorio.Contexto
{
    public class MainContext : DbContext
    {
        public MainContext() : base(@"Server=localhost,1433;Database=NavDB;User=sa;Password=sqlServer@123;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
