using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [Route("api/[controller]")]
    public class CondutorController : BaseController<Condutor>
    {
        public CondutorController(ICondutorRepository repositorio) : base(repositorio)
        {

        }
    }
}
