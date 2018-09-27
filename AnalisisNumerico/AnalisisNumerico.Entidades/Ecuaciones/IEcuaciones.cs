using AnalisisNumerico.Entidades.Ecuaciones;

namespace AnalisisNumerico.Entidades
{
    public interface IEcuaciones
    {
        ResultadoEcuacionesGaussJordan GaussJordan(ParametroGaussJordan parametro);

        ResultadoEcuacionesGaussSeided GaussSeided(ParametroGaussSeided parametro);
    }
}
