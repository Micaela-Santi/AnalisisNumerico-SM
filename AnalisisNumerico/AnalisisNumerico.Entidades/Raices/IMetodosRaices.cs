namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        ResultadoRegresion Biseccion(ParametroCompuesto parametos);
        ResultadoRegresion ReglaFalsa(ParametroCompuesto parametos);
        ResultadoRegresion NewtonRaphson(ParametroSimple parametros);
        ResultadoRegresion Secante(ParametroCompuesto parametros);
    }
}
