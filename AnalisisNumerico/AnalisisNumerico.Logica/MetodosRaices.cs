using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {

        private double CalcularXR(double Xi,double Xd)
        {
            return (Xi + Xd) / 2;
        }
        private double CalcularXR(double xi, double xd, double resultadoxi, double resultadoxd)
        {
            return ((resultadoxd * xi) - (resultadoxi * xd)) / (resultadoxd - resultadoxi);
        }
        private double EvaluarFuncion(string funcionparametro, double valor)
        {
            var funcion = new Function(funcionparametro);
            var argumento = new Argument("x", valor);
            var nombre = funcionparametro.Split('=')[0].Trim();
            var expresion = new Expression(nombre, funcion, argumento);
            return expresion.calculate();
        }
        private Resultado BuscarRaices(ParametrosBiseccion parametros)
        {
            Resultado resultado = new Resultado();
            resultado.ErrorRelativo = 0;
            resultado.Iteraciones = 0;
            int contador = 0;
            double anterior = 0;
            var XI = parametros.Xi;
            var XD = parametros.Xd;
            double xr = 0;
            if (parametros.Biseccion)
            {
                xr = this.CalcularXR(parametros.Xi,parametros.Xd);
            }
            else
            {
                var RFresultadoxi = this.EvaluarFuncion(parametros.Funcion, parametros.Xi);
                var RFresultadoxd = this.EvaluarFuncion(parametros.Funcion, parametros.Xd);
                xr = this.CalcularXR(parametros.Xi, parametros.Xd, RFresultadoxi, RFresultadoxd);
            }
            var errorRelativo = (Math.Abs(xr - anterior) / xr);
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
                if (parametros.Biseccion)
                {
                    xr = this.CalcularXR(XI, XD);
                }
                else
                {
                    var RFresultadoxi = this.EvaluarFuncion(parametros.Funcion, parametros.Xi);
                    var RFresultadoxd = this.EvaluarFuncion(parametros.Funcion, parametros.Xd);
                    xr = this.CalcularXR(parametros.Xi, parametros.Xd, RFresultadoxi, RFresultadoxd);
                }
                contador += 1;
                errorRelativo = (Math.Abs(xr - anterior) / xr);
                resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);
            }
            if (Math.Abs(resultadoXR) < parametros.Tolerancia)
            {
                resultado.Raiz = xr;
                return resultado;
            }
            while (Math.Abs(errorRelativo) > parametros.Tolerancia & contador < parametros.Iteraciones & Math.Abs(resultadoXR) > parametros.Tolerancia)
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
                if (parametros.Biseccion)
                {
                    xr = this.CalcularXR(XI, XD);
                }
                else
                {
                    var RFresultadoxi = this.EvaluarFuncion(parametros.Funcion, parametros.Xi);
                    var RFresultadoxd = this.EvaluarFuncion(parametros.Funcion, parametros.Xd);
                    xr = this.CalcularXR(parametros.Xi, parametros.Xd, RFresultadoxi, RFresultadoxd);
                }
                contador += 1;
                errorRelativo = (Math.Abs(xr - anterior) / xr);
                resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);

            }
            resultado.Iteraciones = contador;
            resultado.ErrorRelativo = errorRelativo;
            resultado.Raiz = xr;
            return resultado;
        }
        public Resultado MetodoBiseccion(ParametrosBiseccion parametros)
        {
            Resultado resultado = new Resultado();
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
