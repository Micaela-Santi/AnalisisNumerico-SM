using AnalisisNumerico.Entidades.Ecuaciones;
using AnalisisNumerico.Entidades.Regresion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalisisNumerico.Logica
{
    public class MetodosRegresion : IRegresion
    {
        private readonly IEcuaciones Ecuaciones;

        public MetodosRegresion(IEcuaciones ecuaciones)
        {
            Ecuaciones = ecuaciones;
        }


        public ResultadoRegresion MetodoRegresionLineal(ParametroRegresion parametro)
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
            Devolver.CoeficienteCorrelacion = this.CalcularCoeficienteDeCorrelacion(parametro, PromedioY, new List<double>() { A0, A1 });


            return Devolver;
        }


        public ResultadoRegresion MetodoPolinomial(ParametroRegresion parametro, int grado)
        {
            var n = grado;
            int filas = n + 1;
            int columnas = n + 2;
            double[,] Matriz = new double[filas, columnas];

            int contador = 0;

            for (int i = 0; i < filas; i++)
            {
                Matriz[i, columnas -1] = CalcularSumatoriaConXElevado(parametro.ValoresX, parametro.ValoresY, i);

                contador = i;

                for (int c = 0; c < columnas -1; c++)
                {

                    Matriz[i, c] = CalcularSumatoriaConXElevado(parametro.ValoresX, contador);

                    contador += 1;
                }

            }
            Matriz[0, 0] = parametro.ValoresX.Count;
            var resultado = Ecuaciones.GaussJordan(new ParametroGaussJordan(filas, columnas)
            {
                Matriz = Matriz,
                NumeroIncognitas = grado + 1
            });



            double promY = parametro.ValoresY.Sum(x => x) / parametro.ValoresY.Count;

            List<double> ResultadoA = resultado.Solucion.Select(X => X.Valor).ToList();

            return new ResultadoRegresion()
            {
                Resultado = ResultadoA,

                CoeficienteCorrelacion = CalcularCoeficienteDeCorrelacion(parametro, promY, ResultadoA)

            };

        }


        public ResultadoRegresion MetodoLagrange(ParametroRegresion parametro, double ValorX)
        {
            int CantPuntos = parametro.ValoresX.Count;
            double Resultado = 0;

            for (int j = 0; j < CantPuntos ; j++)
            {
                double Productoria = 1;

                for (int i = 0; i < CantPuntos; i++)
                {
                    if (j!= i)
                    {
                        Productoria = Productoria * ((ValorX - parametro.ValoresX[i]) / (parametro.ValoresX[j] - parametro.ValoresX[i]));  
                    }
                }

                Resultado += Productoria * parametro.ValoresY[j];
            }

            ResultadoRegresion retornar = new ResultadoRegresion();

            retornar.Resultado.Add(Resultado);
            retornar.CoeficienteCorrelacion = 0;

            return retornar;
        }


        private double CalcularSumatoriaConXElevado(List<double> valoresX, List<double> valoresY, int exponente)
        {
            double resultado = 0;

            for (int i = 0; i < valoresX.Count; i++)
            {
                resultado += Math.Pow(valoresX[i], exponente) * valoresY[i];
            }

            return resultado;
        }

        private double CalcularSumatoriaConXElevado(List<double> valoresX, int exponente)
        {
            return valoresX.Sum(x => Math.Pow(x, exponente));
        }


        private double CalcularCoeficienteDeCorrelacion(ParametroRegresion parametro, double PromedioY, List<double> A)
        {
            double St = parametro.ValoresY.Sum(x => Math.Abs(PromedioY - x));
            double Sr = 0;
            double Aux = 0;
            for (int i = 0; i < parametro.ValoresX.Count; i++)
            {
                double sumA = 0;

                for (int c = (A.Count - 1); c != 0; c--)
                {
                    sumA += A[c] * Math.Pow(parametro.ValoresX[i], c);
                }

                Aux += sumA + (A[0] - parametro.ValoresY[i]);
                Sr += Math.Pow(Aux, 2);
            }

            double Coeficiente = Math.Abs((St - Sr) / St);

            return Math.Sqrt(Coeficiente)* 100;
        }
    }
}
