using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ParametroSimple
    {
        public double Tolerancia { get; set; }
        public int Iteraciones { get; set; }
        public double Xi { get; set; }
        public string Funcion { get; set; }
    }
}
