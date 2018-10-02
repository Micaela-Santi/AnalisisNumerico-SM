using System.Collections.Generic;

namespace AnalisisNumerico.Entidades.Regresion
{
    public interface IRegresion
    {
        List<decimal> MetodoMinimosCuadrados(ParametroRegresionLineal parametro);
    }
}
