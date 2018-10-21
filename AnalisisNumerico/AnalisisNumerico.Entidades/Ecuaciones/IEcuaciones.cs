using AnalisisNumerico.Entidades.Ecuaciones;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public interface IEcuaciones
    {
        ResultadoEcuacionesGaussJordan GaussJordan(ParametroGaussJordan parametro);

        ResultadoEcuacionesGaussSeided GaussSeided(ParametroGaussSeided parametro);
    }
}
