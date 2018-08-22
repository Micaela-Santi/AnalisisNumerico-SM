﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ParametrosCerrados
    {
        public int Iteraciones { get; set; }
        public double Tolerancia { get;set; }
        public double Xi { get; set; }
        public double Xd { get; set; }
        public string Funcion { get; set; }
        public bool EsBiseccion { get; set; }
    }
}