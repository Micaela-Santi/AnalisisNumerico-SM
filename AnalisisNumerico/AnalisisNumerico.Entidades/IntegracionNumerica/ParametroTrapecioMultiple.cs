using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.IntegracionNumerica
{
    public class ParametroTrapecioMultiple: ParametroTrapecioSimple
    {
        public int CantSubIntervalos { get; set; }
    }
}
