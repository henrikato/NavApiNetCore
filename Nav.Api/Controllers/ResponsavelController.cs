using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [Route("api/[controller]")]
    public class ResponsavelController : BaseController<Responsavel>
    {
        public ResponsavelController(IResponsavelRepository repositorio) : base(repositorio)
        {
        }
    }
}
