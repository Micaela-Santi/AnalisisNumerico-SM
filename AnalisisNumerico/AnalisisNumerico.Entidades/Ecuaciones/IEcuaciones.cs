using AnalisisNumerico.Entidades.Ecuaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public interface IEcuaciones
    {
        ResultadoEcuacionesGaussJordan GaussJordan(ParametroGaussJordan parametro);

        ResultadoEcuacionesGaussSeided GaussSeided(ParametroGaussSeided parametro);
    }
}
