using AnalisisNumerico.Entidades.IntegracionNumerica;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Logica
{
    public class MetodosIntegracionNumerica : IIntegracionNumerica
    {
        public ResultadoIntegracionNumerica MetodoDelTrapecioMultiple(ParametroTrapecioMultiple parametro)
        {
            var h = (parametro.ValorB - parametro.ValorA) / parametro.CantSubIntervalos;
            var FValorA = EvaluarFuncion(parametro.Funcion, parametro.ValorA);
            var FValorB = EvaluarFuncion(parametro.Funcion, parametro.ValorB);

            double X = parametro.ValorA + h;
            double sumatoria = 0;

            while (X < parametro.ValorB)
            {
                sumatoria += EvaluarFuncion(parametro.Funcion,X);
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
