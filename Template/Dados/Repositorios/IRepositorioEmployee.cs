using System.Collections.Generic;
using System.Threading.Tasks;
using Template.Auxiliares;
using Template.Dados.Entidades;

namespace Template.Dados.Repositorios
{
    public interface IRepositorioEmployee : IRepositorioBase<HrContext, Employee>
    {
        Task<List<Employee>> ListarEmployeesdAssincrono(ParametrosEmployee parametros);
    }
}