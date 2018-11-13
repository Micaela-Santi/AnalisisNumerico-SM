using System;
using org.mariuszgromada.math.mxparser;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {
        private readonly IUtilidad Utilidad;
        public MetodosRaices(IUtilidad utilidad)
        {
            Utilidad = utilidad;
        }

        private delegate double MetodoCerradoDelegate(double xi, double xd, string funcion);

        private double CalcularXrBiseccion(double xi, double xd, string funcion)
        {
            return (xi + xd) / 2;
        }

        private double CalcularXrReglaFalsa(double xi, double xd, string funcion)
        {
            var resultadoxi = Utilidad.EvaluarFuncion(funcion, xi);
            var resultadoxd = Utilidad.EvaluarFuncion(funcion, xd);
            return ((resultadoxd * xi) - (resultadoxi * xd)) / (resultadoxd - resultadoxi);
        }

        public ResultadoRegresion Biseccion(ParametroCompuesto parametros)
        {
            return this.MetodosCerrados(parametros, CalcularXrBiseccion);
        }

        public ResultadoRegresion ReglaFalsa(ParametroCompuesto parametros)
        {
            return this.MetodosCerrados(parametros, CalcularXrReglaFalsa);
        }

        private ResultadoRegresion MetodosCerrados(ParametroCompuesto parametros, MetodoCerradoDelegate calcularXr)
        {
            ResultadoRegresion resultado = new ResultadoRegresion();
            var resultadoxi = Utilidad.EvaluarFuncion(parametros.Funcion, parametros.Xi);
            var resultadoxd = Utilidad.EvaluarFuncion(parametros.Funcion, parametros.Xd);

            if (resultadoxi.Equals(double.NaN) || resultadoxd.Equals(double.NaN))
            {
                throw new ArgumentException("Verificar Función", "parametros.Funcion");
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

            return this.BuscarRaicesCerrados(parametros, calcularXr);
        }

        private ResultadoRegresion BuscarRaicesCerrados(ParametroCompuesto parametros, MetodoCerradoDelegate calcularXr)
        {
            ResultadoRegresion resultado = new ResultadoRegresion
            {
                ErrorRelativo = 0,
                Iteraciones = 0
            };

            int contador = 0;
            double anterior = 0;
            double errorRelativo = 0;
            var XI = parametros.Xi;
            var XD = parametros.Xd;
            double xr = calcularXr(XI, XD, parametros.Funcion);

            if (xr != 0)
            {
                errorRelativo = (xr - anterior) / xr;
            }

            var resultadoXR = Utilidad.EvaluarFuncion(parametros.Funcion, xr);

            while ((Math.Abs(errorRelativo) > parametros.Tolerancia || xr == 0) && contador < parametros.Iteraciones && Math.Abs(resultadoXR) > parametros.Tolerancia)
            {
                if (Utilidad.EvaluarFuncion(parametros.Funcion, XI) * Utilidad.EvaluarFuncion(parametros.Funcion, xr) > 0)
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

                resultadoXR = Utilidad.EvaluarFuncion(parametros.Funcion, xr);
            }

            resultado.Iteraciones = contador;
            resultado.ErrorRelativo = errorRelativo;
            resultado.Raiz = xr;

            return resultado;
        }

        public ResultadoRegresion NewtonRaphson(ParametroSimple parametros)
        {
            ResultadoRegresion resultado = new ResultadoRegresion()
            {
                Iteraciones = 0,
                ErrorRelativo = 0
            };

            double resultadoXr = Utilidad.EvaluarFuncion(parametros.Funcion, parametros.Xi);

            if (resultadoXr.Equals(Double.NaN))
            {
                throw new ArgumentException("Verificar Funcion", "Funcion");
            }

            if (resultadoXr == 0)
            {
                resultado.Raiz = parametros.Xi;
                return resultado;
            }

            double Anterior = 0;
            int Contador = 0;
            double ValorX = parametros.Xi;
            double Tolerancia = parametros.Tolerancia;
            double ValorXTole = (ValorX + Tolerancia);
            double ValorFXTole = Utilidad.EvaluarFuncion(parametros.Funcion, ValorXTole);
            double ValorXfun = Utilidad.EvaluarFuncion(parametros.Funcion, ValorX);
            double ValorNumerador = ValorFXTole - ValorXfun;
            double Derivada = ValorNumerador / Tolerancia;
            double xr = 0;
            double errorRelativo = 0;
            
            do
            {
                if (Math.Abs(Derivada) < parametros.Tolerancia)
                {
                    throw new NoRaizException(ValorX, "La Recta TG en este punto es horizontal", Contador);
                }

                xr = ValorX - (Utilidad.EvaluarFuncion(parametros.Funcion, ValorX) / Derivada);
                resultadoXr = Utilidad.EvaluarFuncion(parametros.Funcion, xr);

                if (resultadoXr.Equals(double.NaN))
                {
                    throw new NoRaizException(xr, "El valor no pertenece al dominio de la Funcion", Contador);
                }

                errorRelativo = (xr - Anterior) / xr;
                Contador += 1;

                Anterior = xr;
                ValorX = xr;
                ValorXTole = (ValorX + Tolerancia);
                ValorFXTole = Utilidad.EvaluarFuncion(parametros.Funcion, ValorXTole);
                ValorXfun = Utilidad.EvaluarFuncion(parametros.Funcion, ValorX);
                ValorNumerador = ValorFXTole - ValorXfun;
                Derivada = ValorNumerador / Tolerancia;

            } while (Math.Abs(resultadoXr) > Tolerancia && Contador < parametros.Iteraciones && (Math.Abs(errorRelativo) > Tolerancia || xr == 0));

 
            if (Math.Abs(resultadoXr) > Tolerancia * 100)
            {
                throw new NoRaizException(xr, "Valor muy alejado de la raiz", Contador);
            }

            resultado.Raiz = xr;
            resultado.ErrorRelativo = Math.Abs(errorRelativo);
            resultado.Iteraciones = Contador;

            return resultado;
        }

        public ResultadoRegresion Secante(ParametroCompuesto parametros)
        {
            ResultadoRegresion resultado = new ResultadoRegresion()
            {
                Iteraciones = 0,
                ErrorRelativo = 0
            };

            VerificaParametros(parametros);

            var resultadoxi = Utilidad.EvaluarFuncion(parametros.Funcion, parametros.Xi);
            var resultadoxd = Utilidad.EvaluarFuncion(parametros.Funcion, parametros.Xd);

            if (resultadoxd * resultadoxi == 0)
            {
                if (resultadoxd == 0)
                {
                    resultado.Raiz = parametros.Xd;
                }
                else
                {
                    resultado.Raiz = parametros.Xi;
                }

                return resultado;
            }

            double errorRelativo = 0;
            int contador = 0;
            double anterior = 0;
            var Xi = parametros.Xi;
            var Xd = parametros.Xd;
            double Xr = 0;
            double resultadoXr = 0;

            do
            {
                if ((Utilidad.EvaluarFuncion(parametros.Funcion, Xi) - Utilidad.EvaluarFuncion(parametros.Funcion, Xd)) == 0)
                {
                    throw new DivideByZeroException("División por 0");
                }

                Xr = ((Utilidad.EvaluarFuncion(parametros.Funcion, Xi) * Xd) - (Utilidad.EvaluarFuncion(parametros.Funcion, Xd) * Xi)) / ((Utilidad.EvaluarFuncion(parametros.Funcion, Xi) - Utilidad.EvaluarFuncion(parametros.Funcion, Xd)));
                resultadoXr = Utilidad.EvaluarFuncion(parametros.Funcion, Xr);
                contador += 0;

                if (resultadoXr.Equals(double.NaN))
                {
                    throw new NoRaizException(Xr, "Punto fuera del dominio de la funcion", 0);
                }

                if (double.IsInfinity(resultadoXr))
                {
                    throw new NoRaizException(Xr, "La Funcion evaluada en este punto es infinita", contador);
                }

                if (Xr != 0)
                {
                    errorRelativo = ((Xr - anterior) / Xr);
                }

                Xi = Xd;
                Xd = Xr;
                anterior = Xr;

            } while ((Math.Abs(errorRelativo) > parametros.Tolerancia || Xr == 0) && contador < parametros.Iteraciones && Math.Abs(resultadoXr) > parametros.Tolerancia);

        
            if (Math.Abs(resultadoXr) > parametros.Tolerancia * 100)
            {
                throw new NoRaizException(Xr, "Valor muy alejado de la raiz", contador);
            }

            resultado.Raiz = Xr;
            resultado.Iteraciones = contador;
            resultado.ErrorRelativo = Math.Abs(errorRelativo);


            return resultado;
        }

        private void VerificaParametros(ParametroCompuesto parametro)
        {
            var resultadoxi = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.Xi);
            var resultadoxd = Utilidad.EvaluarFuncion(parametro.Funcion, parametro.Xd);

            if (resultadoxi.Equals(double.NaN) && resultadoxd.Equals(double.NaN))
            {
                throw new ArgumentException("Verificar Funcion", "Funcion");
            }

            if (resultadoxi.Equals(Double.NaN) && (resultadoxd.Equals(Double.NaN) == false))
            {
                throw new ArgumentException("Parametro XI fuera del dominio de la F(x)", "Xi");
            }

            if ((resultadoxi.Equals(Double.NaN) == false) && (resultadoxd.Equals(Double.NaN)))
            {
                throw new ArgumentException("Parametro XD fuera del dominio de la F(x)", "Xd");
            }
        }

    }

}
