using AnalisisNumerico.Entidades.Regresion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalisisNumerico.Logica
{
    public class MetodosRegresion : IRegresion
    {
        public ResultadoRegresion MetodoMinimosCuadrados(ParametroRegresionLineal parametro)
        {
            ResultadoRegresion Devolver = new ResultadoRegresion();

            var n = parametro.ValoresX.Count;
            var SumatoriaX = parametro.ValoresX.Sum();
            var SumatoriaY = parametro.ValoresY.Sum();
            var SumatoriaXCuadrada = parametro.ValoresX.Sum(x => x * x);
            double SumatoriaXporY = 0;
            var PromedioY = SumatoriaY / n;
            var PromedioX = SumatoriaX / n;

            for (int i = 0; i < parametro.ValoresX.Count; i++)
            {
                SumatoriaXporY = SumatoriaXporY + (parametro.ValoresX[i] * parametro.ValoresY[i]);
            }

            var A1 = ((n * SumatoriaXporY) - (SumatoriaX * SumatoriaY)) / ((n * SumatoriaXCuadrada) - (SumatoriaX * SumatoriaX));
            var A0 = PromedioY - (A1 * PromedioX);

            Devolver.Resultado.Add(A0);
            Devolver.Resultado.Add(A1);
            Devolver.CoeficienteCorrelacion = this.CalcularCoeficienteDeCorrelacion(parametro,PromedioY,A0,A1);


            return Devolver;
        }

        private double CalcularCoeficienteDeCorrelacion(ParametroRegresionLineal parametro, double PromedioY, double A0 ,double A1)
        {
            double St = parametro.ValoresY.Sum(x => Math.Abs(PromedioY - x));
            double Sr = 0;
            double Aux = 0;
            for (int i = 0; i < parametro.ValoresX.Count; i++)
            {
                Aux += (A1 * parametro.ValoresX[i]) + (A0 - parametro.ValoresY[i]);
                Sr += Math.Pow(Aux, 2);
            }

            double Coeficiente = ((St - Sr) / St);

            return Math.Sqrt(Coeficiente);
        }
    }
}
