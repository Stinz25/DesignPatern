using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory.Factories;
using AbstractFactory.Entities;

namespace Tests
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void TestSingleton()
        {
            //chaise moderne qui provient de la factory
            var factory = new ModernFactory();
            var factoryChaise = factory.CreateChaise();

            //Vérif
            Assert.IsInstanceOfType(factoryChaise, typeof(ModernChaise));

        }
    }
}
