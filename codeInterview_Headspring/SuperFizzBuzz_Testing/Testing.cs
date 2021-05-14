using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz_Testing;

namespace SuperFizzBuzz_Testing
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void Test_1()
        {

            var a = true;

            Assert.IsTrue(a);
        }


        [TestMethod]
        public void Test_2()
        {
            var a = true;
            Assert.IsFalse(a,"Esto debe ser False");
        }
    }
}
