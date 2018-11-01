using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.IntegracionNumerica
{
    public interface IIntegracionNumerica
    {
        ResultadoIntegracionNumerica MetodoDelTrapecioSimple(ParametroTrapecioSimple parametro);
        ResultadoIntegracionNumerica MetodoDelTrapecioMultiple(ParametroTrapecioMultiple parametro);
        ResultadoIntegracionNumerica SimpsonUnTercio(ParametroSimpsonUnTercio parametro);
        ResultadoIntegracionNumerica SimpsonUnTercioMultiple(ParametroSimpsonUnTercioMultiple parametro);
    }

}
