using System.Collections.Generic;

namespace AnalisisNumerico.Entidades.Regresion
{
    public class ParametroRegresionLineal
    {
        public List<decimal> ValoresX { get; set; }
        public List<decimal> ValoresY { get; set; }

        public ParametroRegresionLineal()
        {
            ValoresX = new List<decimal>();
            ValoresY = new List<decimal>();
        }
    }
}
