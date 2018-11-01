using AnalisisNumerico.Entidades.IntegracionNumerica;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosIntegracionNumerica : IIntegracionNumerica
    {
        private readonly IUtilidad Utilidad;
        public MetodosIntegracionNumerica(IUtilidad utilidad)
        {
            Utilidad = utilidad;
        }
        public ResultadoIntegracionNumerica MetodoDelTrapecioMultiple(ParametroTrapecioMultiple parametro)
        {
            var h = (parametro.ValorB - parametro.ValorA) / parametro.CantSubIntervalos;
            var FValorA = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorA);
            var FValorB = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorB);

            double X = parametro.ValorA + h;
            double sumatoria = 0;

            while (X < parametro.ValorB)
            {
                sumatoria += Utilidad.EvaluarFuncion(parametro.Funcion, X);
                X += h;
            }

            double resultado = (h / 2) * (FValorA + (2 * sumatoria) + FValorB);

            return new ResultadoIntegracionNumerica()
            {
                Valor = resultado
            };
        }

        public ResultadoIntegracionNumerica MetodoDelTrapecioSimple(ParametroTrapecioSimple parametro)
        {
            double resultado = 0;

            var resultadoA = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorA);
            var resultadoB = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorB);

            if (double.IsNaN(resultadoA) || double.IsNaN(resultadoB))
            {
                throw new ArgumentException("Verificar Función");
            }

            resultado = ((resultadoA + resultadoB) * (parametro.ValorB - parametro.ValorA)) / 2;

            return new ResultadoIntegracionNumerica()
            {
                Valor = resultado
            };
        }

        public ResultadoIntegracionNumerica SimpsonUnTercio(ParametroSimpsonUnTercio parametro)
        {
            double puntoMedio = (parametro.ValorA + parametro.ValorB) / 2;
            double h = (parametro.ValorB - parametro.ValorA) / 2;
            double area = 0;
            area = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorA)
                    + (Utilidad.EvaluarFuncion(parametro.Funcion, puntoMedio) * 4)
                    +  Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorB);
            area = area * (h / 3);

            return new ResultadoIntegracionNumerica
            {
                Valor = area
            };
        }

        public ResultadoIntegracionNumerica SimpsonUnTercioMultiple(ParametroSimpsonUnTercioMultiple parametro)
        {
            if (Math.Pow(-1,parametro.CantIntervalos) < 0)
            {
                return SimpsonTresOctavos(parametro);
            }

            double h = (parametro.ValorB - parametro.ValorA) / parametro.CantIntervalos;
            double sumatoriaX1 = 0;
            double sumatoriaX2 = 0;
            double valorX = parametro.ValorA + h;

            //for (int i = 0; i < (parametro.CantIntervalos - 1); i += 2)
            //{
            //    sumatoriaX1 += Utilidad.EvaluarFuncion(parametro.Funcion, valorX);
            //    valorX += h;
            //}
            while (valorX < (parametro.ValorB-h))
            {
                sumatoriaX1 += Utilidad.EvaluarFuncion(parametro.Funcion, valorX);
                valorX += h;
            }

            valorX = parametro.ValorA + h;

            while (valorX < (parametro.ValorB - (h*2)))
            {
                sumatoriaX2 += Utilidad.EvaluarFuncion(parametro.Funcion, valorX);
                valorX += h;
            }
            //for (int i = 0; i < (parametro.CantIntervalos - 2); i += 2)
            //{
            //    sumatoriaX2 += Utilidad.EvaluarFuncion(parametro.Funcion, valorX);
            //    valorX += h;
            //}

            double area = 0;
            area = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorA) 
                + (4 * sumatoriaX1) 
                + (sumatoriaX2 * 2) 
                + Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorB);
            area = area * (h / 3);

            return new ResultadoIntegracionNumerica
            {
                Valor = area
            };
        }

        private ResultadoIntegracionNumerica SimpsonTresOctavos(ParametroSimpsonUnTercioMultiple parametro)
        {
            double h = (parametro.ValorB - parametro.ValorA) / parametro.CantIntervalos;
            double ValorAPrima = parametro.ValorB - (h * 3);

            var resultadoUnTercio = SimpsonUnTercioMultiple(new ParametroSimpsonUnTercioMultiple
            {
                ValorA = parametro.ValorA,
                ValorB = ValorAPrima,
                CantIntervalos = parametro.CantIntervalos - 3,
                Funcion = parametro.Funcion
            });

            double ValorX1 = ValorAPrima + h;
            double valorX2 = ValorX1 + h;
            double area = Utilidad.EvaluarFuncion(parametro.Funcion, ValorAPrima)
                            + (3 * Utilidad.EvaluarFuncion(parametro.Funcion, ValorX1))
                            + (3 * Utilidad.EvaluarFuncion(parametro.Funcion, valorX2))
                            + Utilidad.EvaluarFuncion(parametro.Funcion, parametro.ValorB);
            area = area * (3 / 8 * h);

            return new ResultadoIntegracionNumerica
            {
                Valor = area + resultadoUnTercio.Valor
            };
        }
    }
}
