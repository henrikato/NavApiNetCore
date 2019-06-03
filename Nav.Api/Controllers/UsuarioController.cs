using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : BaseController<Usuario, long>
    {
        private readonly IUsuarioRepository _repositorio;

        public UsuarioController(IUsuarioRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public override async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            try
            {
                var retorno = await _repositorio.GetAll();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        public override async Task<ActionResult<Usuario>> Get(long id)
        {
            try
            {
                var retorno = await _repositorio.Get(id);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        public override async Task<ActionResult> Post([FromBody] Usuario entidade)
        {
            try
            {
                var retorno = await _repositorio.Post(entidade);
                if (!retorno)
                {
                    return UnprocessableEntity(new
                    {
                        Mensagem = "Não foi possível incluir o registro, verifique as informações e tente novamente.",
                        Objeto = retorno
                    });
                }
                return CreatedAtAction("POST", new { entidade.Id }, entidade);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        public override async Task<ActionResult> Put(long id, [FromBody] Usuario entidade)
        {
            try
            {
                var retorno = await _repositorio.Put(id, entidade);
                if (!retorno)
                {
                    return UnprocessableEntity(new
                    {
                        Mensagem = "Não foi possível atualizar o registro, verifique as informações e tente novamente.",
                        Objeto = retorno
                    });
                }

                return Ok(new { Mensagem = $"Registro #{id} atualizado com suceesso.", Objeto = retorno });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        public override async Task<ActionResult> Delete(long id)
        {
            try
            {
                var retorno = await _repositorio.Delete(id);
                if (!retorno)
                {
                    return UnprocessableEntity(new
                    {
                        Mensagem = $"Não foi possível excluir o registro (ID {id}), verifique as informações e tente novamente.",
                    });
                }

                return Ok(new { Mensagem = $"Registro {id} excluído com sucesso." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
