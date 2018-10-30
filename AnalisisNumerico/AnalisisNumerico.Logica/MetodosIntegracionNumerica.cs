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
            var FValorA = EvaluarFuncion(parametro.Funcion, parametro.ValorA);
            var FValorB = EvaluarFuncion(parametro.Funcion, parametro.ValorB);

            double X = parametro.ValorA + h;
            double sumatoria = 0;

            while (X < parametro.ValorB)
            {
                sumatoria += EvaluarFuncion(parametro.Funcion, X);
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

            var resultadoA = EvaluarFuncion(parametro.Funcion, parametro.ValorA);
            var resultadoB = EvaluarFuncion(parametro.Funcion, parametro.ValorB);

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
            double h = parametro.ValorB - parametro.ValorA / 2;
            double area = 0;
            area = EvaluarFuncion(parametro.Funcion, parametro.ValorA) + (EvaluarFuncion(parametro.Funcion, puntoMedio) * 4) + EvaluarFuncion(parametro.Funcion, parametro.ValorB);
            area = area * (h / 3);

            return new ResultadoIntegracionNumerica
            {
                Valor = area
            };
        }

        public ResultadoIntegracionNumerica SimpsonUnTercioMultiple(ParametroSimpsonUnTercioMultiple parametro)
        {
            double h = (parametro.ValorB - parametro.ValorA) / parametro.CantIntervalos;
            double sumatoriaX1 = 0;
            double sumatoriaX2 = 0;
            double valorX = parametro.ValorA + h;

            for (int i = 1; i < (parametro.CantIntervalos - 1); i += 2)
            {
                sumatoriaX1 += EvaluarFuncion(parametro.Funcion, valorX);
                valorX += h;
            }

            valorX = parametro.ValorA + h;

            for (int i = 1; i < (parametro.CantIntervalos - 2); i += 2)
            {
                sumatoriaX2 += EvaluarFuncion(parametro.Funcion, valorX);
                valorX += h;
            }

            double area = 0;
            area = EvaluarFuncion(parametro.Funcion, parametro.ValorA) + (4 * sumatoriaX1) + (sumatoriaX2 * 2) + EvaluarFuncion(parametro.Funcion, parametro.ValorB);
            area = area * (h / 3);

            return new ResultadoIntegracionNumerica
            {
                Valor = area
            };
        }

        public ResultadoIntegracionNumerica SimpsonTresOctavos(ParametroSimpsonUnTercioMultiple parametro)
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
            double area = EvaluarFuncion(parametro.Funcion, ValorAPrima)
                            + (3 * EvaluarFuncion(parametro.Funcion, ValorX1))
                            + (3 * EvaluarFuncion(parametro.Funcion, valorX2))
                            + EvaluarFuncion(parametro.Funcion, parametro.ValorB);
            area = area * (3 / 8 * h);

            return new ResultadoIntegracionNumerica
            {
                Valor = area + resultadoUnTercio.Valor
            };
        }
        private double EvaluarFuncion(string funcionParametro, double valor)
        {
            var funcion = new Function(funcionParametro);
            var argumento = new Argument("x", valor);
            var nombre = funcionParametro.Split('=')[0].Trim();
            var expresion = new Expression(nombre, funcion, argumento);
            return expresion.calculate();
        }
    }
}
