using System.Collections.Generic;
using System.Threading.Tasks;
using Nav.Dominio.Entidades;

namespace Nav.Repositorio.Repositorios
{
    public interface IBaseRepository<T> where T : EntidadeBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(long id);
        Task<bool> Post(T entidade);
        Task<bool> Put(long id, T entidade);
        Task<bool> Delete(long id);
    }
}
