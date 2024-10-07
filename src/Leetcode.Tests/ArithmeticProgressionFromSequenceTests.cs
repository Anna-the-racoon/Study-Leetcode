using Leetcode.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests;

[TestClass()]
public class ArithmeticProgressionFromSequenceTests
{
    [TestMethod()]
    public void CanMakeArithmeticProgressionTest()
    {
        var service = new ArithmeticProgressionFromSequence();

        Assert.AreEqual(true, service.CanMakeArithmeticProgression([3, 5, 1]));

        Assert.AreEqual(false, service.CanMakeArithmeticProgression([1, 2, 4]));
    }
}