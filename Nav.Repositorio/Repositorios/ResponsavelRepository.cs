using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public class ResponsavelRepository : BaseRepository<Responsavel>, IResponsavelRepository
    {
        public ResponsavelRepository(MainContext context) : base(context)
        {
        }
    }
}
