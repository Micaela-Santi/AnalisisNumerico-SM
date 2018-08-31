using System;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalisisNumerico.Test
{
    [TestClass]
    public class TestMetodoNewtonRaphson
    {
        private ParametroSimple Parametro { get; set; }
        private MetodosRaices MetodosRaices { get; set; }

        public TestMetodoNewtonRaphson()
        {
            this.Parametro = new ParametroCompuesto();
            this.MetodosRaices = new MetodosRaices();
            Parametro.Funcion = "f(x) = x - 2";
            Parametro.Tolerancia = 0.0001;
            Parametro.Iteraciones = 100;
        }

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FuncionMalIngresada()
        {
            Parametro.Funcion = "4x";
            Parametro.Xi = 2;

            MetodosRaices.NewtonRaphson(Parametro);
        }

    }
}
