using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class NoRaizException:Exception
    {
        public NoRaizException(Double valor, string mensaje,int iteraciones):base(mensaje)
        {
            this.Valor = valor;
            this.Iteraciones = iteraciones;
        }

        public double Valor { get; set; }  
        public int Iteraciones { get; set; }
    }
}
