using AnalisisNumerico.Entidades;
using AnalisisNumerico.Entidades.Ecuaciones;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosEcuaciones : IEcuaciones
    {
        public ResultadoEcuacionesGaussJordan GaussJordan(ParametroGaussJordan parametro)
        {
            ResultadoEcuacionesGaussJordan resultado = new ResultadoEcuacionesGaussJordan();
            int fila = parametro.NumeroIncognitas - 1;
            int columna = parametro.NumeroIncognitas;

            for (int i = 0; i <= (columna - 1); i++)
            {

                AcomodarFilas(parametro.Matriz, i, fila, columna);

                Normalizacion(parametro.Matriz, i, columna);

                HacerCero(parametro.Matriz, i, fila, columna);

            }

            for (int i = 0; i < parametro.NumeroIncognitas; i++)
            {
                Incognita incognita = new Incognita();
                incognita.Valor = parametro.Matriz[i, columna];
                resultado.Solucion.Add(incognita);
            }


            return resultado;
        }

        private void AcomodarFilas(decimal[,] matriz, int incognitaActual, int filas, int columnas)
        {
            decimal Mayor = -1;
            int FilaMayor = 0;
            for (int i = incognitaActual; i <= filas; i++)
            {
                if (Mayor < Math.Abs(matriz[i, incognitaActual]))
                {
                    Mayor = Math.Abs(matriz[i, incognitaActual]);
                    FilaMayor = i;
                }
            }

            if (Mayor == -1)
            {
                throw new Exception("El sistema NO es normal");
            }

            for (int c = 0; c <= columnas; c++)
            {

                var Aux = matriz[incognitaActual, c];
                matriz[incognitaActual, c] = matriz[FilaMayor, c];
                matriz[FilaMayor, c] = Aux;

            }

        }

        private void Normalizacion(decimal[,] matriz, int fila, int cantColumnas)
        {
            decimal divisor = matriz[fila, fila];
            for (int i = 0; i <= cantColumnas; i++)
            {
                matriz[fila, i] = (matriz[fila, i] / divisor);
            }
        }

        private void HacerCero(decimal[,] matriz, int filaActual, int cantFilas, int cantColumnas)
        {
            for (int i = 0; i <= cantFilas; i++)
            {
                var multiplicar = matriz[i, filaActual];
                if (i != filaActual && matriz[i, filaActual] != 0)
                {
                    for (int x = 0; x <= cantColumnas; x++)
                    {
                        matriz[i, x] = (multiplicar * matriz[filaActual, x] * (-1)) + (matriz[i, x]);
                    }
                }
            }


        }

        public ResultadoEcuacionesGaussSeided GaussSeided(ParametroGaussSeided parametro)
        {
            decimal[] vector = new decimal[parametro.NumeroIncognitas];
            //TODO ver en que empieza
            for (int i = 0; i < parametro.NumeroIncognitas; i++)
            {
                vector[i] = 0;
            }

            double errorRelativo;
            int contador = 0;
            var despejes = DespejarIncognitas(parametro.Matriz);
            do
            {
                EvaluarSoluciones(vector, despejes);

            } while (errorRelativo < parametro.Tolerancia && contador < parametro.Iteraciones);

        }

        private void EvaluarSoluciones(decimal[] vector, decimal[,] despejes)
        {
            throw new NotImplementedException();
        }

        private decimal[,] DespejarIncognitas(decimal[,] matriz)
        { 
            decimal divisor;
            decimal[,] despeje = new decimal[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                divisor = despeje[i, i];

                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if (i != c)
                    {
                        despeje[i, c] = ((despeje[i, c] * (-1)) / divisor);
                    }
                }
            }

            return despeje;
        }
    }
}
