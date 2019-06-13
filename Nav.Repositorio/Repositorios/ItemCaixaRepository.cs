using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public class ItemCaixaRepository : BaseRepository<ItemCaixa>, IItemCaixaRepository
    {
        public ItemCaixaRepository(MainContext context) : base(context)
        {

        }
    }
}
