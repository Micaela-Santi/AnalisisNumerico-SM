using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Logica
{
    public class Utilidad : IUtilidad
    {
        public double EvaluarFuncion(string funcionParametro, double valor)
        {
            var funcion = new Function(funcionParametro);
            var argumento = new Argument("x", valor);
            var nombre = funcionParametro.Split('=')[0].Trim();
            var expresion = new Expression(nombre, funcion, argumento);
            return expresion.calculate();
        }
    }
}
