using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Dados.Repositorios
{
    public class RepositorioBase<TContexto, TEntidade> : IRepositorioBase<TContexto, TEntidade> 
        where TContexto : DbContext
        where TEntidade : class
    {
        private readonly TContexto _contexto;

        public RepositorioBase(TContexto contexto)
        {
            _contexto = contexto;
        }

        public TEntidade ObterPorId(int id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public List<TEntidade> ListarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public Task<TEntidade> ObterPorIdAssincrono(int id)
        {
            return _contexto.Set<TEntidade>().FindAsync(id);
        }

        public async Task<List<TEntidade>> ListarTodosAssincrono()
        {
            return await _contexto.Set<TEntidade>().ToListAsync();
        }
    }
}