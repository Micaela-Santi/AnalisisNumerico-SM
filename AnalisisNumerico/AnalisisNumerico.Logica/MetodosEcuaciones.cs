using AnalisisNumerico.Entidades;
using AnalisisNumerico.Entidades.Ecuaciones;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosEcuaciones : IEcuaciones
    {
        private void AcomodarFilas(decimal[,] matriz, int incognitaActual, int filas)
        {
            decimal Mayor = -1;
            int FilaMayor = 0;
            for (int i = 0; i < filas; i++)
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

            for (int c = 0; c < filas + 1 ; c++)
            {

                var Aux = matriz[incognitaActual, c];
                matriz[incognitaActual, c] = matriz[FilaMayor, c];
                matriz[FilaMayor, c] = Aux;

            }

        }


        private void Normalizacion(decimal[,] matriz, int fila, int cantColumnas)
        {
            for (int i = 0; i < cantColumnas; i++)
            {
                matriz[fila, i] = matriz[fila, i] / matriz[fila, fila];
            }

        }

        private void HacerCero (decimal [,] matriz, int filaActual, int cantFilas)
        {
            for (int i = 0; i < cantFilas; i++)
            {
                if (i != filaActual)
                {
                    for (int x = 0; x < cantFilas; x++)
                    {
                        matriz[i, x] = matriz[i, x] - (matriz[i, x] * matriz[filaActual, x]);
                    }
                }
            }


        }

        public ResultadoEcuaciones GaussJordan(ParmetroGaussJordan parametro)
        {
            ResultadoEcuaciones resultado = new ResultadoEcuaciones();

            for (int i = 0; i < parametro.NumeroIncognitas; i++)
            {

                AcomodarFilas(parametro.Matriz, i, parametro.NumeroIncognitas);

                Normalizacion(parametro.Matriz, i, parametro.NumeroIncognitas);

                HacerCero(parametro.Matriz, i, parametro.NumeroIncognitas);

            }

            for (int i = 0; i < parametro.NumeroIncognitas; i++)
            {
                Incognita incognita = new Incognita();
                incognita.Valor = parametro.Matriz[i, parametro.NumeroIncognitas + 1];
                resultado.Solucion.Add(incognita);
            }
            


            return resultado;
        }

    }
}
