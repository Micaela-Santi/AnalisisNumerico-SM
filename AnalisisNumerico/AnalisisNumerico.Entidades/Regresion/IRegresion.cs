
namespace AnalisisNumerico.Entidades.Regresion
{
    public interface IRegresion
    {
        ResultadoRegresion MetodoRegresionLineal(ParametroRegresion parametro);
        ResultadoRegresion MetodoPolinomial(ParametroRegresion parametro);
    }
}
