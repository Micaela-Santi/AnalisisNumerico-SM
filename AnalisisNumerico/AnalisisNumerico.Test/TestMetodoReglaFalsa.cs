using System;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalisisNumerico.Test
{
    [TestClass]
    public class TestMetodoReglaFalsa
    {
        private ParametroCompuesto Parametro { get; set; }
        private MetodosRaices MetodosRaices { get; set; }

        public TestMetodoReglaFalsa()
        {
            this.Parametro = new ParametroCompuesto();
            this.MetodosRaices = new MetodosRaices();
            Parametro.Funcion = "f(x) = -x^2 + 4";
            Parametro.Tolerancia = 0.0001;
            Parametro.Iteraciones = 100;
        }

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
        [ExpectedException(typeof(ArgumentException))]
        public void ReglaFalsaElIntervaloNoContieneRaiz()
        {
            Parametro.Xi = 40;
            Parametro.Xd = 30;
            Parametro.Funcion = "f(x)= x^3 - 3*x^2";

            MetodosRaices.ReglaFalsa(Parametro);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReglaFalsaFuncionMalIngresada()
        {
            Parametro.Xi = 40;
            Parametro.Xd = 30;
            Parametro.Funcion = "f(x)= 4x";

            MetodosRaices.ReglaFalsa(Parametro);
        }

    }

}
