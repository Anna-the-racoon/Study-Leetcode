using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    [TestClass()]
    public class ArithmeticProgressionFromSequenceTests
    {
        [TestMethod()]
        public void CanMakeArithmeticProgressionTest()
        {
            var service = new ArithmeticProgressionFromSequence();

            Assert.AreEqual(true, service.CanMakeArithmeticProgression(new[] { 3, 5, 1 }));

            Assert.AreEqual(false, service.CanMakeArithmeticProgression(new[] { 1, 2, 4 }));
        }
    }
}