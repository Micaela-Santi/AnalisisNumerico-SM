using AnalisisNumerico.Entidades;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosEcuaciones : IEcuaciones
    {
        public ResultadoEcuaciones GaussJordan(ParmetroGaussJordan parametro)
        {
            ResultadoEcuaciones resultado = new ResultadoEcuaciones();
            int Mayor = -1;
            int Indice = 0;
            for (int i = 0; i < parametro.NumeroColumnas; i++)
            {
                for (int s = 0; s < parametro.NumeroFilas; s++)
                {
                    if (Math.Abs(parametro.Matriz[s, i]) > Mayor)
                    {
                        Mayor = parametro.Matriz[s, i];
                        Indice = s;
                    }
                }
                for (int c = 0; c < parametro.NumeroColumnas; c++)
                {
                    
                }

            }

        }
    }
}
