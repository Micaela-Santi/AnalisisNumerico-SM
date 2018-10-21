namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ParametroGaussJordan
    {
        public int NumeroIncognitas { get; set; }
        public double[,] Matriz { get; set; }

        public ParametroGaussJordan(int filas, int columnas)
        {
            Matriz = new double[filas, columnas];
        }
    }
}
