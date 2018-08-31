using System;
using System.Text;
using System.Collections.Generic;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalisisNumerico.Test
{
    /// <summary>
    /// Descripción resumida de TestMetodoNewtonRaphson
    /// </summary>
    [TestClass]
    public class TestMetodoNewtonRaphson
    {
        public TestMetodoNewtonRaphson()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
            this.Parametro = new ParametroCompuesto();
            this.MetodosRaices = new MetodosRaices();
            Parametro.Funcion = "f(x) = x - 2";
            Parametro.Tolerancia = 0.0001;
            Parametro.Iteraciones = 100;
        }
        private ParametroSimple Parametro { get; set; }
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
        public void NewtonRaphsonXiesRaiz()
        {
            Parametro.Xi = 2;
            var resultado = this.MetodosRaices.NewtonRaphson(this.Parametro);
            Assert.AreEqual(Parametro.Xi, resultado.Raiz);
            Assert.AreEqual(0, resultado.ErrorRelativo);
            Assert.AreEqual(0, resultado.Iteraciones);
        }

        [TestMethod]
        public void NewtonRaphsonComun()
        {
            Parametro.Xi = 100;
            var resultado = this.MetodosRaices.NewtonRaphson(this.Parametro);
            Assert.IsTrue(resultado.Raiz > 1.9 && resultado.Raiz < 2.1);
            Assert.IsTrue(resultado.Iteraciones <= Parametro.Iteraciones);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRaizException))]
        public void NewtonRaphsonExtremoValorInicial()
        {
            Parametro.Funcion = "f(x)=((x-1)^2)-4";
            Parametro.Xi = 1;
            MetodosRaices.NewtonRaphson(Parametro);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRaizException))]
        public void NewtonRaphsonExtremo()
        {
            Parametro.Funcion = "f(x)=x^2-4";
            Parametro.Xi = -6;
            MetodosRaices.NewtonRaphson(Parametro);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRaizException))]
        public void NewtonRaphsonValorAlejadoRaiz()
        {
            Parametro.Funcion = "f(x)=((x-1)^2)-4";
            Parametro.Xi = 100;
            Parametro.Iteraciones = 2;
            MetodosRaices.NewtonRaphson(Parametro);
        }

    }
}
