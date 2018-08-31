using System;
using AnalisisNumerico.Logica;
using AnalisisNumerico.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalisisNumerico.Test
{
    [TestClass]
    public class TestMetodoSecante
    {
        private ParametroCompuesto Parametro { get; set; }
        private MetodosRaices MetodosRaices { get; set; }

        public TestMetodoSecante()
        {
            Parametro = new ParametroCompuesto();
            MetodosRaices = new MetodosRaices();
            Parametro.Funcion = "f(x)= x + 2";
            Parametro.Tolerancia = 0.0001;
            Parametro.Iteraciones = 100;
        }

        [TestMethod]
        public void FuncionComun()
        {
            Parametro.Funcion = "f(x)= x -2 ";
            Parametro.Xi = -10;
            Parametro.Xd = 10;
            var resultado = MetodosRaices.Secante(Parametro);

            Assert.IsTrue(resultado.Raiz < 2.1 && resultado.Raiz > 1.8);
            Assert.IsTrue(resultado.Iteraciones <= Parametro.Iteraciones);
            Assert.IsTrue((resultado.ErrorRelativo <= Parametro.Tolerancia) || (resultado.ErrorRelativo == 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SecanteFuncionMalIngresada()
        {
            Parametro.Funcion = "2x";
            Parametro.Xd = 2;
            Parametro.Xi = 4;

            MetodosRaices.Secante(Parametro);
        }

        [TestMethod]
        public void XiEsRaiz()
        {
            Parametro.Xi = -2;
            Parametro.Xd = 4;
            var resultado = MetodosRaices.Secante(Parametro);

            Assert.AreEqual(Parametro.Xi, resultado.Raiz);
            Assert.AreEqual(0, resultado.Iteraciones);
            Assert.AreEqual(0, resultado.ErrorRelativo);
        }

        [TestMethod]
        public void XdEsRaiz()
        {
            Parametro.Xi = -4;
            Parametro.Xd = -2;
            var resultado = MetodosRaices.Secante(Parametro);

            Assert.AreEqual(Parametro.Xd, resultado.Raiz);
            Assert.AreEqual(0, resultado.Iteraciones);
            Assert.AreEqual(0, resultado.ErrorRelativo);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPorCero()
        {
            Parametro.Funcion = "f(x)= x^2";
            Parametro.Xd = 2;
            Parametro.Xi = -2;

            MetodosRaices.Secante(Parametro);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRaizException))]
        public void PuntoFueraDeDominio()
        {
            Parametro.Funcion = "f(x)=x^(1/2)";
            Parametro.Xi = 0.5;
            Parametro.Xd = 10;

            MetodosRaices.Secante(Parametro);
        }

    }

}
