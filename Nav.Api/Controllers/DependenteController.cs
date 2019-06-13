using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [Route("api/[controller]")]
    public class DependenteController : BaseController<Dependente>
    {
        public DependenteController(IDependenteRepository repositorio) : base(repositorio)
        {
        }
    }
}
