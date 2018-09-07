using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ParmetroGaussJordan
    {
        public int NumeroIncognitas { get; set; }
        public int NumeroFilas { get; set; }
        public int NumeroColumnas { get; set; }
        public int [,] Matriz { get; set; }
    }
}
