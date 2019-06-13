using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [Route("api/[controller]")]
    public class ItemCaixaController : BaseController<ItemCaixa>
    {
        public ItemCaixaController(IItemCaixaRepository repositorio) : base(repositorio)
        {

        }
    }
}
