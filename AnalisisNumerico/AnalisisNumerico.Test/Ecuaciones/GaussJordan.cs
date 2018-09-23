﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Logica;

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
            decimal[,] Matriz = new decimal[2,3];
           
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Matriz[i, x] = x + i;
                }
            }

            MetodosEcuaciones metodosEcuaciones = new MetodosEcuaciones();
            var resultado = metodosEcuaciones.GaussJordan(new Entidades.Ecuaciones.ParmetroGaussJordan()
            {
                Matriz = Matriz,
                NumeroIncognitas = 2
            });

            var resul1 = resultado.Solucion[0];
            var resul2 = resultado.Solucion[1];
            var algo = resultado;
        }
    }
}