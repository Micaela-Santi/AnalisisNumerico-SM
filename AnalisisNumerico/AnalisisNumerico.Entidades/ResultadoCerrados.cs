﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ResultadoCerrados
    {
        public double Raiz { get; set; }
        public int Iteraciones { get; set; }
        public double ErrorRelativo { get; set; }
    }
}
