using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ParametroCompuesto: ParametroSimple
    {
        public double Xd { get; set; }
        public bool EsBiseccion { get; set; }
    }
}
