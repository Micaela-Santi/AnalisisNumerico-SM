using AnalisisNumerico.Entidades.Regresion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalisisNumerico.Logica
{
    public class MetodosRegresion : IRegresion
    {
        public List<decimal> MetodoMinimosCuadrados(ParametroRegresionLineal parametro)
        {
            List<decimal> Devolver = new List<decimal>();

            var n = parametro.ValoresX.Count;
            var SumatoriaX = parametro.ValoresX.Sum();
            var SumatoriaY = parametro.ValoresY.Sum();
            var SumatoriaXCuadrada = parametro.ValoresX.Sum(x => x * x);
            var SumatoriaXporY = 0M;
            var PromedioY = SumatoriaY / n;
            var PromedioX = SumatoriaX / n;

            for (int i = 0; i < parametro.ValoresX.Count; i++)
            {
                SumatoriaXporY = SumatoriaXporY + (parametro.ValoresX[i] * parametro.ValoresY[i]);
            }

            var A1 = ((n * SumatoriaXporY) - (SumatoriaX * SumatoriaY)) / ((n * SumatoriaXCuadrada) - (SumatoriaX * SumatoriaX));
            var A0 = PromedioY - (A1 * PromedioX);

            Devolver.Add(A0);
            Devolver.Add(A1);

            return Devolver;
        }
    }
}
