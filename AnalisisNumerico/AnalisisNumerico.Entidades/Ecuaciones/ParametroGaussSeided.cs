using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ParametroGaussSeided : ParametroGaussJordan
    {
        public double Tolerancia { get; set; }
        public int Iteraciones { get; set; }

        public ParametroGaussSeided(int filas, int columnas) : base(filas, columnas)
        {
        }


    }
}
