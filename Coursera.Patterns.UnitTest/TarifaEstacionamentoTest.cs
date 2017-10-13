using Coursera.Patterns.Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coursera.Patterns.UnitTest
{
    [TestClass]
    public class TarifaEstacionamentoTest
    {
        [TestMethod]
        public void TarifaComValorInicialDentroDoLimite()
        {
            var tarifa = new TarifaEstacionamento(2, new CalculoHoraValorInicial(5, 3, 2));
            var valor = tarifa.Valor();
            Assert.AreEqual(5, valor);
        }

        [TestMethod]
        public void TarifaComValorInicialDepoisFixaPorHora()
        {
            var tarifa = new TarifaEstacionamento(5, new CalculoHoraValorInicial(5, 3, 2));
            var valor = tarifa.Valor();
            Assert.AreEqual(9, valor);
        }

        [TestMethod]
        public void TarifaDiaria()
        {
            var tarifa = new TarifaEstacionamento(50, new CalculoDiaria(20));
            var valor = tarifa.Valor();
            Assert.AreEqual(60, valor);
        }

        [TestMethod]
        public void TarifaDiariaMenorQueUmDia()
        {
            var tarifa = new TarifaEstacionamento(10, new CalculoDiaria(20));
            var valor = tarifa.Valor();
            Assert.AreEqual(20, valor);
        }

        [TestMethod]
        public void TarifaFixaPorHora()
        {
            var tarifa = new TarifaEstacionamento(3, new CalculoHora(4));
            var valor = tarifa.Valor();
            Assert.AreEqual(12, valor);
        }
    }
}