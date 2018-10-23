
namespace AnalisisNumerico.Entidades.Regresion
{
    public interface IRegresion
    {
        ResultadoRegresion MetodoRegresionLineal(ParametroRegresion parametro);
        ResultadoRegresion MetodoPolinomial(ParametroRegresion parametro, int grado);
        ResultadoRegresion MetodoLagrange(ParametroRegresion parametro, double ValorX);
    }
}
