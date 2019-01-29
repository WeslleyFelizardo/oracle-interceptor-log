using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Dados.Entidades;

namespace Template.Dados.Repositorios
{
    public class RepositorioEmployee : RepositorioBase<HrContext, Employee>
    {
        public RepositorioEmployee(HrContext contexto) 
            : base(contexto)
        {
        }
    }
}
