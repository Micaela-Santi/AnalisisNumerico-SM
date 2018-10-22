using System.Collections.Generic;

namespace AnalisisNumerico.Entidades.Regresion
{
    public class ParametroRegresion
    {
        public List<double> ValoresX { get; set; }
        public List<double> ValoresY { get; set; }

        public ParametroRegresion()
        {
            ValoresX = new List<double>();
            ValoresY = new List<double>();
        }
    }
}
