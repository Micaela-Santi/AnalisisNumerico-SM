using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ParmetroGaussJordan
    {
        public int NumeroIncognitas { get; set; }
        public decimal[,] Matriz { get; set; }

        public ParmetroGaussJordan(int filas, int columnas)
        {
            Matriz = new decimal[filas, columnas];
        }
    }
}
