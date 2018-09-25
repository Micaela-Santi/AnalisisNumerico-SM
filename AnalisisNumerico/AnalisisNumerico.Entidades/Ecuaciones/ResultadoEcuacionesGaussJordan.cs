using AnalisisNumerico.Entidades.Ecuaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ResultadoEcuacionesGaussJordan
    {
        public List<Incognita> Solucion { get; set;}

        public ResultadoEcuacionesGaussJordan()
        {
            this.Solucion = new List<Incognita>();
        }
    }
}
