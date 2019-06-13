using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public class CondutorRepository : BaseRepository<Condutor>, ICondutorRepository
    {
        public CondutorRepository(MainContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<Condutor>> GetAll()
        {
            try
            {
                return await _context.Condutores
                    .Include(x => x.Funcionarios)
                    .Include(x => x.FluxoCaixa)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
