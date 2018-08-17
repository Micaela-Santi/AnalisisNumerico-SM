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
        

        private double EvaluarFuncion(string nombrefuncion, double valor)
        {
            var funcion = new Function(nombrefuncion);
            var argumento = new Argument("x", valor);
            var nombre = nombrefuncion.Split('=')[0].Trim();
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
            var xr = (parametros.Xd + parametros.Xi) / 2;
            var errorRelativo = (xr - anterior) / xr;
            var resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);
            if (resultadoXR < parametros.Tolerancia)
            {
                resultado.Raiz = xr;
                return resultado;
            }
            while (errorRelativo < parametros.Tolerancia || contador > parametros.Iteraciones || resultadoXR < parametros.Tolerancia)
            {
                if (EvaluarFuncion(parametros.Funcion, XI)* EvaluarFuncion(parametros.Funcion,xr) > 0)
                {
                    XI = xr;
                }
                else
                {
                    XD = xr;
                }
                anterior = xr;
                xr = (XI + XD) / 2;
                contador += 1;
                errorRelativo = (xr - anterior) / xr;
                resultadoXR = this.EvaluarFuncion(parametros.Funcion, xr);
                if (resultadoXR < 0)
                {
                    resultadoXR = resultadoXR * (-1);
                }
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
                   if (resultadoxi != 0)
                   {
                       resultado.Raiz = resultadoxi;

                   }
                   else
                   {
                       resultado.Raiz = resultadoxd;
                   }

                   resultado.Iteraciones = 0;
                   resultado.ErrorRelativo = 0;
                   return resultado;
               }

            return this.BuscarRaices(parametros);
           }
           
    }
}
