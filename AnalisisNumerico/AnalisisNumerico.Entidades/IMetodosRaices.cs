using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado Biseccion(ParametroCompuesto parametos);
        Resultado ReglaFalsa(ParametroCompuesto parametos);
        Resultado NewtonRaphson(ParametroSimple parametros);
        Resultado Secante(ParametroCompuesto parametros);
    }
}
