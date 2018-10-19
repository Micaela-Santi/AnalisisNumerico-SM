using System.Collections.Generic;

namespace AnalisisNumerico.Entidades.Regresion
{
    public class ResultadoRegresion
    {
        public List<double> Resultado { get; set; }
        public double CoeficienteCorrelacion { get; set; }

        public ResultadoRegresion()
        {
            Resultado = new List<double>();
        }
    }
}
