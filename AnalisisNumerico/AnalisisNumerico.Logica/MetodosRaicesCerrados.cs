using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaicesCerrados : IMetodosRaices
    {
        private double CalcularXR(double xi, double xd, bool biseccion, string funcion)
        {
            if (biseccion)
            {
                return (xi + xd) / 2;
            }
            else
            {
                var resultadoxi = this.EvaluarFuncion(funcion, xi);
                var resultadoxd = this.EvaluarFuncion(funcion, xd);
                return ((resultadoxd * xi) - (resultadoxi * xd)) / (resultadoxd - resultadoxi);
            }
        }
        private double EvaluarFuncion(string funcionparametro, double valor)
        {
            var funcion = new Function(funcionparametro);
            var argumento = new Argument("x", valor);
            var nombre = funcionparametro.Split('=')[0].Trim();
            var expresion = new Expression(nombre, funcion, argumento);
            return expresion.calculate();
        }
        private ResultadoCerrados BuscarRaices(ParametrosCerrados parametros)
        {
            ResultadoCerrados resultado = new ResultadoCerrados();
            resultado.ErrorRelativo = 0;
            resultado.Iteraciones = 0;
            int contador = 0;
            double anterior = 0;
            var XI = parametros.Xi;
            var XD = parametros.Xd;
            bool errorvalido = true;
            double xr = this.CalcularXR(XI, XD, parametros.Biseccion, parametros.Funcion);
            var errorRelativo = (xr - anterior) / xr;
            var resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);
            if (errorRelativo != 1)
            {
                if (EvaluarFuncion(parametros.Funcion, XI) * EvaluarFuncion(parametros.Funcion, xr) > 0)
                {
                    XI = xr;
                }
                else
                {
                    XD = xr;
                }
                anterior = xr;
                xr = this.CalcularXR(XI, XD, parametros.Biseccion, parametros.Funcion);
                contador += 1;
                if (xr > ((parametros.Tolerancia) * 10))
                {
                    errorRelativo = (xr - anterior) / xr;
                }
                else
                {
                    errorvalido = false;
                }
                resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);
            }
            if (Math.Abs(resultadoXR) < parametros.Tolerancia)
            {
                resultado.Raiz = xr;
                return resultado;
            }
            while ((Math.Abs(errorRelativo) > parametros.Tolerancia & xr != 0) & contador < parametros.Iteraciones & Math.Abs(resultadoXR) > parametros.Tolerancia)
            {
                if (EvaluarFuncion(parametros.Funcion, XI) * EvaluarFuncion(parametros.Funcion, xr) > 0)
                {
                    XI = xr;
                }
                else
                {
                    XD = xr;
                }
                anterior = xr;
                xr = this.CalcularXR(XI, XD, parametros.Biseccion, parametros.Funcion);
                contador += 1;
                if (xr > ((parametros.Tolerancia) * 10))
                {
                    errorRelativo = (xr - anterior) / xr;
                    errorvalido = true;
                }
                else
                {
                    errorvalido = false;
                }
                resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);

            }
            resultado.Iteraciones = contador;
            if (errorvalido)
            {
                resultado.ErrorRelativo = errorRelativo;
            }
            else
            {
                resultado.ErrorRelativo = double.MaxValue;
            }
            resultado.Raiz = xr;
            return resultado;
        }
        public ResultadoCerrados MetodoBiseccion(ParametrosCerrados parametros)
        {
            ResultadoCerrados resultado = new ResultadoCerrados();
            var resultadoxi = EvaluarFuncion(parametros.Funcion, parametros.Xi);
            var resultadoxd = EvaluarFuncion(parametros.Funcion, parametros.Xd);

            if (resultadoxi * resultadoxd > 0)
            {
                throw new ArgumentException("Ingresar nuevamente los extremos", "parametros.Xi");
            }

            if (resultadoxi * resultadoxd == 0)
            {
                if (resultadoxi == 0)
                {
                    resultado.Raiz = parametros.Xi;
                }
                else
                {
                    resultado.Raiz = parametros.Xd;
                }
                resultado.Iteraciones = 0;
                resultado.ErrorRelativo = 0;
                return resultado;
            }
            return this.BuscarRaices(parametros);
        }
    }
}
