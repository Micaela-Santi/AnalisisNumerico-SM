using System.Collections.Generic;

namespace AnalisisNumerico.Entidades.Regresion
{
    public class ParametroRegresionLineal
    {
        public List<double> ValoresX { get; set; }
        public List<double> ValoresY { get; set; }

        public ParametroRegresionLineal()
        {
            ValoresX = new List<double>();
            ValoresY = new List<double>();
        }
    }
}
