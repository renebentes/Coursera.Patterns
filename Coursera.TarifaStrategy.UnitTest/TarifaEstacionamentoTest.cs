using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coursera.TarifaStrategy.UnitTest
{
    [TestClass]
    public class TarifaEstacionamentoTest
    {
        [TestMethod]
        public void TarifaFixaPorHora()
        {
            var tarifa = new TarifaEstacionamento(3, new CalculoHora(4));
            var valor = tarifa.Valor();
            Assert.AreEqual(12, valor);
        }
    }
}