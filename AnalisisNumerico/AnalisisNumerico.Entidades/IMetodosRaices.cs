namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado Biseccion(ParametroCompuesto parametos);
        Resultado ReglaFalsa(ParametroCompuesto parametos);
        Resultado NewtonRaphson(ParametroSimple parametros);
        Resultado Secante(ParametroCompuesto parametros);
    }

}
