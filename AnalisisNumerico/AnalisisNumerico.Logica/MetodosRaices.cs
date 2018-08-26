﻿using System;
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
        private delegate double MetodoCerradoDelegate(double xi, double xd, string funcion);

        public Resultado Biseccion(ParametroCompuesto parametros)
        {
            return this.MetodosCerrados(parametros, CalcularXrBiseccion);
        }

        public Resultado ReglaFalsa(ParametroCompuesto parametros)
        {
            return this.MetodosCerrados(parametros, CalcularXrReglaFalsa);
        }

        private double CalcularXrBiseccion(double xi, double xd, string funcion)
        {
            return (xi + xd) / 2;
        }

        private double CalcularXrReglaFalsa(double xi, double xd, string funcion)
        {
            var resultadoxi = this.EvaluarFuncion(funcion, xi);
            var resultadoxd = this.EvaluarFuncion(funcion, xd);
            return ((resultadoxd * xi) - (resultadoxi * xd)) / (resultadoxd - resultadoxi);
        }

        private double EvaluarFuncion(string funcionParametro, double valor)
        {
            var funcion = new Function(funcionParametro);
            var argumento = new Argument("x", valor);
            var nombre = funcionParametro.Split('=')[0].Trim();
            var expresion = new Expression(nombre, funcion, argumento);
            return expresion.calculate();
        }

        private Resultado BuscarRaicesCerrados(ParametroCompuesto parametros, MetodoCerradoDelegate calcularXr)
        {
            Resultado resultado = new Resultado
            {
                ErrorRelativo = 0,
                Iteraciones = 0
            };

            int contador = 0;
            double anterior = 0;
            var XI = parametros.Xi;
            var XD = parametros.Xd;
            double xr = calcularXr(XI, XD, parametros.Funcion);
            var errorRelativo = (xr - anterior) / xr;
            var resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);

            if (Math.Abs(resultadoXR) < parametros.Tolerancia)
            {
                resultado.Raiz = xr;
                return resultado;
            }

            while ((Math.Abs(errorRelativo) > parametros.Tolerancia | xr == 0) & contador < parametros.Iteraciones & Math.Abs(resultadoXR) > parametros.Tolerancia)
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
                xr = calcularXr(XI, XD, parametros.Funcion);
                contador += 1;

                if (Math.Abs(xr) > ((parametros.Tolerancia) * 10))
                {
                    errorRelativo = (xr - anterior) / xr;
                }

                resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);
            }

            resultado.Iteraciones = contador;
            resultado.ErrorRelativo = errorRelativo;
            resultado.Raiz = xr;

            return resultado;
        }

        private Resultado MetodosCerrados(ParametroCompuesto parametros, MetodoCerradoDelegate calcularXr)
        {
            Resultado resultado = new Resultado();
            var resultadoxi = EvaluarFuncion(parametros.Funcion, parametros.Xi);
            var resultadoxd = EvaluarFuncion(parametros.Funcion, parametros.Xd);

            if (resultadoxi.ToString() == double.NaN.ToString() | resultadoxd.ToString() == double.NaN.ToString())
            {
                throw new Exception("Ingrese nuevamente la Función");
            }

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
            return this.BuscarRaicesCerrados(parametros,calcularXr);
        }

        public Resultado NewtonRaphson(ParametroSimple parametros)
        {
            Resultado resultado = new Resultado()
            {
                Iteraciones = 0,
                ErrorRelativo = 0
            };

            if (EvaluarFuncion(parametros.Funcion, parametros.Xi) == 0)
            {
                resultado.Raiz = parametros.Xi;
                return resultado;
            }
            
            double Anterior = 0;
            int Contador = 0;
            double ValorX = parametros.Xi;
            double Tolerancia = parametros.Tolerancia;
            double Derivada = (EvaluarFuncion(parametros.Funcion, (ValorX + Tolerancia)) - EvaluarFuncion(parametros.Funcion,ValorX)) / Tolerancia;
            double xr = ValorX - (EvaluarFuncion(parametros.Funcion, ValorX) / Derivada);
            double resultadoXr = EvaluarFuncion(parametros.Funcion, xr);
            double errorRelativo = (xr - Anterior) / xr;
            Contador += 1;

            if (EvaluarFuncion(parametros.Funcion,Derivada) == 0)
            {
                throw new Exception("La recta TG no corta al eje X");
            }

            while (Math.Abs(resultadoXr) > Tolerancia  & Contador < parametros.Iteraciones & (Math.Abs(errorRelativo) > Tolerancia | xr == 0))
            {
                Anterior = xr;
                ValorX = xr;
                Derivada = (EvaluarFuncion(parametros.Funcion, (ValorX + Tolerancia)) - EvaluarFuncion(parametros.Funcion, ValorX)) / Tolerancia;
                xr = ValorX - (EvaluarFuncion(parametros.Funcion, ValorX) / Derivada);
                resultadoXr = EvaluarFuncion(parametros.Funcion, xr);
                errorRelativo = (xr - Anterior) / xr;
                Contador += 1;

                if (EvaluarFuncion(parametros.Funcion, Derivada) == 0)
                {
                    throw new Exception("La recta TG no corta al eje X");
                }
            }

            resultado.Raiz = xr;
            resultado.ErrorRelativo = errorRelativo;
            resultado.Iteraciones = Contador;

            return resultado;
        }

        public Resultado Secante(ParametroCompuesto parametros)
        {
            Resultado resultado = new Resultado();
            var resultadoxi = EvaluarFuncion(parametros.Funcion, parametros.Xi);
            var resultadoxd = EvaluarFuncion(parametros.Funcion, parametros.Xd);

            if (resultadoxi.ToString() == double.NaN.ToString() | resultadoxd.ToString() == double.NaN.ToString())
            {
                throw new Exception("Ingrese nuevamente la Función");
            }
            var Xi = parametros.Xi;
            var Xd = parametros.Xd;
            var Xr = ((EvaluarFuncion(parametros.Funcion, Xi) * Xd) - (EvaluarFuncion(parametros.Funcion, Xd) * Xi))/((EvaluarFuncion(parametros.Funcion,Xi) - EvaluarFuncion(parametros.Funcion,Xd)));
            // TERMINAR
            return resultado;
        }
    }
}