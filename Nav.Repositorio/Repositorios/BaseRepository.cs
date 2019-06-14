using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : EntidadeBase
    {
        protected readonly MainContext _context;

        protected BaseRepository(MainContext context)
        {
            _context = context;
        }

        public virtual async Task<T> Get(long id)
        {
            try
            {
                return await _context.FindAsync<T>(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task<bool> Post(T entidade)
        {
            try
            {
                _context.Add(entidade);
                var retorno = await _context.SaveChangesAsync();
                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task<bool> Put(long id, T entidade)
        {
            try
            {
                var registro = await _context.FindAsync<T>(id);
                if (registro == null) throw new Exception("O registro com o ID informado não foi encontrado");

                _context.Entry(registro).State = EntityState.Modified;
                _context.Entry(registro).CurrentValues.SetValues(entidade);

                var retorno = await _context.SaveChangesAsync();

                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task<bool> Delete(long id)
        {
            try
            {
                var registro = await _context.FindAsync<T>(id);
                if (registro == null) throw new Exception("O registro com o ID informado não foi encontrado");
                _context.Entry(registro).State = EntityState.Deleted;

                var retorno = await _context.SaveChangesAsync();
                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
