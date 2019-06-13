using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Repositorios;

namespace Nav.Api.Controllers
{
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : EntidadeBase
    {
        protected readonly IBaseRepository<T> _repositorio;

        public BaseController(IBaseRepository<T> repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> Get()
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

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<T>> Get(long id)
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

        [HttpPost]
        public virtual async Task<ActionResult> Post([FromBody] T entidade)
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

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Put(long id, [FromBody] T entidade)
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

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(long id)
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

                return Ok(new { Mensagem = $"Registro #{id} excluído com sucesso." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
