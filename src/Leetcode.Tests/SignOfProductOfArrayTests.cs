using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    [TestClass()]
    public class SignOfProductOfArrayTests
    {
        [TestMethod()]
        public void ArraySignTest()
        {
            var service = new SignOfProductOfArray();

            Assert.AreEqual(1, service.ArraySign(new[] { -1, -2, -3, -4, 3, 2, 1 }));

            Assert.AreEqual(0, service.ArraySign(new[] { 1, 5, 0, 2, -3 }));

            Assert.AreEqual(-1, service.ArraySign(new[] { -1, 1, -1, 1, -1 }));

            Assert.AreEqual(-1, service.ArraySign(new[] { 41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41 }));

            Assert.AreEqual(-1, service.ArraySign(new[] { -5 }));
        }
    }
}