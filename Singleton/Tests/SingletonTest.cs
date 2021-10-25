using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace Tests
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestSingleton()
        {
            var singleton1 = MySingleton.GetInstance();
            var singleton2 = MySingleton.GetInstance();

            Assert.AreEqual(singleton2, singleton2);
        
        }
    }
}
