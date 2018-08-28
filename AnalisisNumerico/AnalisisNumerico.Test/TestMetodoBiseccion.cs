using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;

namespace AnalisisNumerico.Test
{
    /// <summary>
    /// Descripción resumida de TestMetodosRaices
    /// </summary>
    [TestClass]
    public class TestMetodoBiseccion
    {
        public TestMetodoBiseccion()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //  
            this.Parametro = new ParametroCompuesto();
            this.MetodosRaices = new MetodosRaices();
            Parametro.Funcion = "f(x) = -x^2 + 4";
            Parametro.Tolerancia = 0.0001;
            Parametro.Iteraciones = 100;

        }
        private ParametroCompuesto Parametro { get; set; }
        private MetodosRaices MetodosRaices { get; set; }

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>


        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void BiseccionXdEsRaiz()
        {
            Parametro.Xd = 2;
            Parametro.Xi = 0;
            var resultado = this.MetodosRaices.Biseccion(this.Parametro);
            Assert.AreEqual(Parametro.Xd, resultado.Raiz);
            Assert.AreEqual(0, resultado.ErrorRelativo);
            Assert.AreEqual(0, resultado.Iteraciones);
        }
        [TestMethod]
        public void BiseccionXiEsRaiz()
        {
            Parametro.Xi = 2;
            Parametro.Xd = 0;
            var resultado = this.MetodosRaices.Biseccion(this.Parametro);
            Assert.AreEqual(Parametro.Xi, resultado.Raiz);
            Assert.AreEqual(0, resultado.ErrorRelativo);
            Assert.AreEqual(0, resultado.Iteraciones);
        }

        [TestMethod]
        public void BiseccionIteracionesMaximas()
        {
            Parametro.Xi = -1.90;
            Parametro.Xd = 10;
            Parametro.Iteraciones = 1;
            var resultado = this.MetodosRaices.Biseccion(this.Parametro);
            Assert.AreEqual(1, resultado.Iteraciones);
        }

        [TestMethod]
        public void BiseccionComun()
        {
            Parametro.Xi = 1;
            Parametro.Xd = 10;
            Parametro.Funcion = "f(x)= x^3 - 3*x^2";
            var resultado = this.MetodosRaices.Biseccion(this.Parametro);
            Assert.IsTrue(resultado.Raiz > 2.8 & resultado.Raiz < 3.2);
            Assert.IsTrue(resultado.Iteraciones <= Parametro.Iteraciones);
            Assert.IsTrue(resultado.ErrorRelativo < Parametro.Tolerancia);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BiseccionElIntervaloNoContieneRaiz()
        {
            Parametro.Xi = 40;
            Parametro.Xd = 30;
            Parametro.Funcion = "f(x)= x^3 - 3*x^2";

            this.MetodosRaices.Biseccion(this.Parametro);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BiseccionFuncionMalIngresada()
        {
            Parametro.Xi = 40;
            Parametro.Xd = 30;
            Parametro.Funcion = "f(x)= 4x";

            var Resultado = this.MetodosRaices.Biseccion(this.Parametro);
        }
    }
}
