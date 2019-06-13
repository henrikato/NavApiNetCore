using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [Route("api/[controller]")]
    public class FuncionarioController : BaseController<Funcionario>
    {
        public FuncionarioController(IFuncionarioRepository repositorio) : base(repositorio)
        {
        }
    }
}
