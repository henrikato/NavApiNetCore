using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nav.Dominio.Entidades;
using Nav.Repositorio.Contexto;

namespace Nav.Repositorio.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MainContext _context = new MainContext();

        public async Task<Usuario> Get(long id)
        {
            try
            {
                return await _context.Usuarios.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            try
            {
                return await _context.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Post(Usuario entidade)
        {
            try
            {
                _context.Usuarios.Add(entidade);
                var retorno = await _context.SaveChangesAsync();
                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Put(long id, Usuario entidade)
        {
            try
            {
                var registro = await _context.Usuarios.FindAsync(id);
                if (registro == null) throw new Exception("O registro com o ID informado não foi encontrado");
                _context.Entry(registro).State = EntityState.Modified;

                _context.Entry(registro).CurrentValues.SetValues(entidade);

                var retorno = await _context.SaveChangesAsync();

                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var registro = await _context.Usuarios.FindAsync(id);
                if (registro == null) throw new Exception("O registro com o ID informado não foi encontrado");
                _context.Entry(registro).State = EntityState.Deleted;

                var retorno = await _context.SaveChangesAsync();
                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
