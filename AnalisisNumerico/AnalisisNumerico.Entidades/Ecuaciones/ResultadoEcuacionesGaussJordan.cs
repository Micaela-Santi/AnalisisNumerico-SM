using AnalisisNumerico.Entidades.Ecuaciones;
using System.Collections.Generic;

namespace AnalisisNumerico.Entidades
{
    public class ResultadoEcuacionesGaussJordan
    {
        public List<Incognita> Solucion { get; set; }

        public ResultadoEcuacionesGaussJordan()
        {
            this.Solucion = new List<Incognita>();
        }
    }
}
