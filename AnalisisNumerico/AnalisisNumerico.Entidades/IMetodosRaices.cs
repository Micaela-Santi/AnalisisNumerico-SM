﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado MetodoBiseccion(ParametrosBiseccion parametos);
    }
}