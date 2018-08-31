using System;
using System.Text;
using System.Collections.Generic;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalisisNumerico.Test
{
    /// <summary>
    /// Descripción resumida de TestMetodoReglaFalsa
    /// </summary>
    [TestClass]
    public class TestMetodoReglaFalsa
    {
        public TestMetodoReglaFalsa()
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
        public void ReglaFalsaXiEsRaiz()
        {
            Parametro.Xi = 2;
            Parametro.Xd = 0;
            var resultado = this.MetodosRaices.ReglaFalsa(this.Parametro);
            Assert.AreEqual(Parametro.Xi, resultado.Raiz);
            Assert.AreEqual(0, resultado.ErrorRelativo);
            Assert.AreEqual(0, resultado.Iteraciones);
        }

        [TestMethod]
        public void ReglaFalsaXdEsRaiz()
        {
            Parametro.Xd = 2;
            Parametro.Xi = 0;
            var resultado = this.MetodosRaices.ReglaFalsa(this.Parametro);
            Assert.AreEqual(Parametro.Xd, resultado.Raiz);
            Assert.AreEqual(0, resultado.ErrorRelativo);
            Assert.AreEqual(0, resultado.Iteraciones);
        }

        [TestMethod]
        public void ReglaFalsaIteracionesMaximas()
        {
            Parametro.Xi = -1.90;
            Parametro.Xd = 10;
            Parametro.Iteraciones = 1;
            var resultado = this.MetodosRaices.ReglaFalsa(this.Parametro);
            Assert.AreEqual(1, resultado.Iteraciones);
        }

        [TestMethod]
        public void ReglaFalsaComun()
        {
            Parametro.Xi = 1;
            Parametro.Xd = 10;
            Parametro.Funcion = "f(x)= x^3 - 3*x^2";
            var resultado = this.MetodosRaices.ReglaFalsa(this.Parametro);
            Assert.IsTrue(resultado.Raiz > 2.8 & resultado.Raiz < 3.2);
            Assert.IsTrue(resultado.Iteraciones <= Parametro.Iteraciones);
            Assert.IsTrue(resultado.ErrorRelativo < Parametro.Tolerancia);
        }

        [TestMethod]
        public void ReglaFalsaElIntervaloNoContieneRaiz()
        {
            Parametro.Xi = 40;
            Parametro.Xd = 30;
            Parametro.Funcion = "f(x)= x^3 - 3*x^2";
            bool Exception = false;
            try
            {
                var Resultado = this.MetodosRaices.ReglaFalsa(this.Parametro);
            }
            catch (ArgumentException)
            {
                Exception = true;
            }
            finally
            {
                Assert.IsTrue(Exception);
            }

        }

        [TestMethod]
        public void ReglaFalsaFuncionMalIngresada()
        {
            Parametro.Xi = 40;
            Parametro.Xd = 30;
            Parametro.Funcion = "f(x)= 4x";
            bool Exception = false;
            try
            {
                var Resultado = this.MetodosRaices.Biseccion(this.Parametro);
            }
            catch (Exception)
            {
                Exception = true;
            }
            finally
            {
                Assert.IsTrue(Exception);
            }

        }
    }
}
