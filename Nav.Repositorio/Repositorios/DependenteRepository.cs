using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public class DependenteRepository : BaseRepository<Dependente>, IDependenteRepository
    {
        public DependenteRepository(MainContext context) : base(context)
        {
        }
    }
}
