namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ResultadoEcuacionesGaussSeided : ResultadoEcuacionesGaussJordan
    {
        public int Iteraciones { get; set; }
        public double ErrorRelativo { get; set; }
    }
}
