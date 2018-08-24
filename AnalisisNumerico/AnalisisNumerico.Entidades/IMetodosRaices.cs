using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado Biseccion(ParametrosCerrados parametos);
        Resultado ReglaFalsa(ParametrosCerrados parametos);
        Resultado NewtonRaphson(ParametrosAbiertos parametros);
    }
}
