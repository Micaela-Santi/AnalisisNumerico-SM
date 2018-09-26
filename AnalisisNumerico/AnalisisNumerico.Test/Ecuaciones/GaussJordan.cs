using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Logica;
using AnalisisNumerico.Entidades.Ecuaciones;

namespace AnalisisNumerico.Test.Ecuaciones
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
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

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            decimal[,] Matriz = new decimal[3,4];
              
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

            
            /*
            Matriz[0, 0] = 4;
            Matriz[0, 1] = 1;
            Matriz[0, 2] = 16;
            Matriz[1, 0] = 4;
            Matriz[1, 1] = 8;
            Matriz[1, 2] = 2;
        */





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
