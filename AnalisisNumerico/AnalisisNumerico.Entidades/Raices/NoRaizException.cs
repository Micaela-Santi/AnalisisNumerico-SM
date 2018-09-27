using System;

namespace AnalisisNumerico.Entidades
{
    public class NoRaizException : Exception
    {
        public double Valor { get; set; }
        public int Iteraciones { get; set; }

        public NoRaizException(Double valor, string mensaje, int iteraciones) : base(mensaje)
        {
            this.Valor = valor;
            this.Iteraciones = iteraciones;
        }
    }
}
