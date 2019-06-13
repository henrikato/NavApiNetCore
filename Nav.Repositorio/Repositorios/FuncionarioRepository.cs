using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(MainContext context) : base(context)
        {
        }
    }
}
