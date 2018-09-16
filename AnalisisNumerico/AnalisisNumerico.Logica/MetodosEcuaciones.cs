using AnalisisNumerico.Entidades;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosEcuaciones : IEcuaciones
    {

        private void AcomodaFila(double[,] matriz, int columnaActual,int filaActual, int cantidadfilas, int cantidadColumnas)
        {
            double Mayor = -1;
            int Indice = -1;
           
            for (int s = 0; s < cantidadfilas; s++)
            {
                if (Math.Abs(matriz[s, columnaActual]) > Mayor)
                {
                    Mayor = matriz[s, columnaActual];
                    Indice = s;
                }
            }

            if (Mayor == -1)
            {
                throw new Exception("Toda la columna es de 0");
            }

            for (int c = 0; c < cantidadColumnas; c++)
            {
                var aux = matriz[filaActual, c];
                matriz[filaActual, c] = matriz[Indice, c];
                matriz[Indice, c] = aux;
            }
            
        }
       
    }
}
