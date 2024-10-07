using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests;

[TestClass()]
public class SubtractTheProductAndSumOfDigitsOfAnIntegerTests
{
    [TestMethod()]
    public void SubtractProductAndSumTest()
    {
        var service = new SubtractTheProductAndSumOfDigitsOfAnInteger();

        var result = service.SubtractProductAndSum(234);
        Assert.AreEqual(15, result);

        result = service.SubtractProductAndSum(4421);
        Assert.AreEqual(21, result);
    }
}