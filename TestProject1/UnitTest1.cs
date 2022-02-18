using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.addNumbers(2,3), 5);  
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Program.addNumbers(2, 3), "five");
        }

    }
}