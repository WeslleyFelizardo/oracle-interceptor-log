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
        protected readonly TContexto Contexto;

        public RepositorioBase(TContexto contexto)
        {
            Contexto = contexto;
        }

        public TEntidade ObterPorId(int id)
        {
            return Contexto.Set<TEntidade>().Find(id);
        }

        public List<TEntidade> ListarTodos()
        {
            return Contexto.Set<TEntidade>().ToList();
        }

        public Task<TEntidade> ObterPorIdAssincrono(int id)
        {
            return Contexto.Set<TEntidade>().FindAsync(id);
        }

        public async Task<List<TEntidade>> ListarTodosAssincrono()
        {
            return await Contexto.Set<TEntidade>().ToListAsync();
        }
    }
}