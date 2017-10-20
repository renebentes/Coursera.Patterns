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

        // 1ª Implementação usando ExpectedExceptionAttribute
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrechoComEscalaAeroportosDiferentesAtributo()
        {
            var trechoInicial = new TrechoAereoSimples("GRU", "BSB", 200, 400);
            var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
            var trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoFinal);
        }

        // 2ª Implementação usando try/catch para capturar uma execeção gerada
        // e assim testar sua nulidade
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

        // 3ª Implementação usando um Action para testar uma exceção
        //[TestMethod]
        //public void TrechoComEscalaAeroportosDiferentes()
        //{
        //    var trechoInicial = new TrechoAereoSimples("GRU", "BSB", 200, 400);
        //    var trechoFinal = new TrechoAereoSimples("FOR", "NAT", 150, 200);
        //    ITrechoAereo trechoComEscala;

        //    Assert.ThrowsException<ArgumentException>(() => trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoFinal));
        //}

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

        public void TrechoComEscalaConexao()
        {
            var trechoInicial = new TrechoAereoSimples("GRU", "FOR", 200, 400);
            var trechoMeio = new TrechoAereoSimples("FOR", "NAT", 150, 200);
            var trechoFinal = new TrechoAereoSimples("NAT", "BSB", 250, 300);
            var trechoComEscala = new TrechoAereoComEscala(trechoInicial, trechoMeio);
            var trechoComConexao = new TrechoAereoComConexao(trechoComEscala, trechoFinal, 50);
            Assert.AreEqual("GRU", trechoComConexao.Origem);
            Assert.AreEqual("BSB", trechoComConexao.Destino);
            Assert.AreEqual(650, trechoComConexao.Custo);
            Assert.AreEqual(900, trechoComConexao.Distancia);
        }
    }
}