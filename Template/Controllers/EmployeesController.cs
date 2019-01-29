using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.Dados;
using Template.Dados.Entidades;
using Template.Dados.Repositorios;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepositorioBase<HrContext, Employee> _repositorio;

        public EmployeesController(IRepositorioBase<HrContext, Employee> repositorio)
        {
            _repositorio = repositorio;
        }


        //public ActionResult<List<Employee>> Obter()
        //{
        //    List<Employee> employees;

        //    using (var contexto = new HrContext())
        //    {
        //        employees = contexto.Employees.ToList();
        //    }

        //    return employees;
        //}

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> ObterAsync()
        {
            //List<Employee> employees;

            //using (var contexto = new HrContext())
            //{
            //    employees = await contexto.Employees.ToListAsync().ConfigureAwait(false);
            //}

            //return employees;

            return await _repositorio.ListarTodosAssincrono().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> ObterPorIdAsync([FromRoute] int id)
        {
            return await _repositorio.ObterPorIdAssincrono(id).ConfigureAwait(false);
        }
    }
}