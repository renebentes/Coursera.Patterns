using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coursera.Patterns.Composite;
using System;

namespace Coursera.Patterns.UnitTest
{
    [TestClass]
    public class TrechosCompostosTest
    {
        [TestMethod]
        public void TrechoComEscala()
        {
            var trechoInicial = new TrechoAereoSimples("GRU", "FOR", 200, 400);
            var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
            var trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoFinal);
            Assert.AreEqual("GRU", trechoComEscala.Origem);
            Assert.AreEqual("NAT", trechoComEscala.Destino);
            Assert.AreEqual(350, trechoComEscala.Custo);
            Assert.AreEqual(600, trechoComEscala.Distancia);
        }

        // [TestMethod]
        // [ExpectedException(typeof(ArgumentException))]
        // public void TrechoComEscalaAeroportosDiferentesAtributo()
        // {
        //     var trechoInicial = new TrechoAereoSimples("GRU", "BSB", 200, 400);
        //     var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
        //     var trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoFinal);
        // }

        // [TestMethod]
        // public void TrechoComEscalaAeroportosDiferentes()
        // {
        //     var trechoInicial = new TrechoAereoSimples("GRU", "BSB", 200, 400);
        //     var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
        //     Exception exception = null;
        //     try
        //     {
        //         var trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoFinal);
        //     }
        //     catch (Exception ex)
        //     {
        //         exception = ex;
        //     }

        //     Assert.IsNotNull(exception);
        // }

        [TestMethod]
        public void TrechoComEscalaAeroportosDiferentes()
        {
            var trechoInicial = new TrechoAereoSimples("GRU", "BSB", 200, 400);
            var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
            ITrechoAereo trechoComEscala;

            Assert.ThrowsException<ArgumentException>(() => trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoFinal));
        }

        [TestMethod]
        public void TrechoComConexao()
        {
            var trechoInicial = new TrechoAereoSimples("GRU", "FOR", 200, 400);
            var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
            var trechoComConexao = new TrechoAereoComConexao(trechoInicial, trechoFinal, 80);
            Assert.AreEqual("GRU", trechoComConexao.Origem);
            Assert.AreEqual("NAT", trechoComConexao.Destino);
            Assert.AreEqual(430, trechoComConexao.Custo);
            Assert.AreEqual(600, trechoComConexao.Distancia);
        }
    }
}