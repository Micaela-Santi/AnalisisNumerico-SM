using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ResultadoEcuacionesGaussSeided:ResultadoEcuacionesGaussJordan
    {
        public int Iteraciones { get; set; }
        public double Tolerancia { get; set; }
    }
}
