using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nav.Dominio.Entidades;

namespace Nav.Api.Controllers
{
    [ApiController]
    public abstract class BaseController<T, TId> : ControllerBase where T : EntidadeBase
    {
        // GET api/values
        [HttpGet]
        public abstract Task<ActionResult<IEnumerable<T>>> Get();

        // GET api/values/5
        [HttpGet("{id}")]
        public abstract Task<ActionResult<T>> Get(TId id);

        // POST api/values
        [HttpPost]
        public abstract Task<ActionResult> Post([FromBody] T entidade);

        // PUT api/values/5
        [HttpPut("{id}")]
        public abstract Task<ActionResult> Put(TId id, [FromBody] T entidade);

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public abstract Task<ActionResult> Delete(TId id);
    }
}
