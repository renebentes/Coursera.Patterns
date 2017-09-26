using Coursera.Patterns.NullObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coursera.Patterns.UnitTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemComDescontoAbsoluto()
        {
            var item = new Item("tenis", 150);
            Assert.AreEqual(300.0, item.PrecoQuantidade(2));
            Assert.AreEqual("tenis R$150", item.ToString());
        }

        [TestMethod]
        public void ItemComDescontoPercentual()
        {
            var item = new Item("tenis", 150.0, new DescontoPercentual(10));
            Assert.AreEqual(270.0, item.PrecoQuantidade(2), 0.001);
            Assert.AreEqual("tenis R$135", item.ToString());
        }

        [TestMethod]
        public void ItemSemDesconto()
        {
            var item = new Item("tenis", 150.0, new DescontoAbsoluto(10));
            Assert.AreEqual(280.0, item.PrecoQuantidade(2), 0.001);
            Assert.AreEqual("tenis R$140", item.ToString());
        }
    }
}