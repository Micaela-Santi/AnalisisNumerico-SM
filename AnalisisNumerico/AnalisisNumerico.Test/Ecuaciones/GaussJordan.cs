using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Logica;
using AnalisisNumerico.Entidades.Ecuaciones;

namespace AnalisisNumerico.Test.Ecuaciones
{

    [TestClass]
    public class GaussJordan
    {
        public GaussJordan()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            decimal[,] Matriz = new decimal[3, 4];

            Matriz[0, 0] = 10;
            Matriz[0, 1] = -3;
            Matriz[0, 2] = 2;
            Matriz[0, 3] = -3;
            Matriz[1, 0] = 5;
            Matriz[1, 1] = 60;
            Matriz[1, 2] = -1;
            Matriz[1, 3] = 13;
            Matriz[2, 0] = 4;
            Matriz[2, 1] = -1;
            Matriz[2, 2] = 30;
            Matriz[2, 3] = 8;

            MetodosEcuaciones metodosEcuaciones = new MetodosEcuaciones();

            var resultado = metodosEcuaciones.GaussSeided(new ParametroGaussSeided(Matriz.GetLength(0), Matriz.GetLength(1))
            {
                Iteraciones = 100,
                Tolerancia = 0.0001,
                Matriz = Matriz,
                NumeroIncognitas = 3
            });

            var resul1 = resultado.Solucion[0];
            var resul2 = resultado.Solucion[1];
            var resul3 = resultado.Solucion[2];
            var algo = resultado;

        }
    }
}