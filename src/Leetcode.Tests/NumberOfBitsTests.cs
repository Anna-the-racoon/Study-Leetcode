using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests;

[TestClass()]
public class NumberOfBitsTests
{
    [TestMethod()]
    public void HammingWeightTest()
    {
        var service = new NumberOfBits();

        var result = service.HammingWeight(Convert.ToUInt32("00000000000000000000000000001011", 2));
        Assert.AreEqual(3, result);

        result = service.HammingWeight(Convert.ToUInt32("00000000000000000000000010000000", 2));
        Assert.AreEqual(1, result);

        Assert.AreEqual(31, service.HammingWeight(Convert.ToUInt32("11111111111111111111111111111101", 2)));

        var number = "10000000000000000000000000000000";
        Assert.AreEqual(1, service.HammingWeight(Convert.ToUInt32("10000000000000000000000000000000", 2)));
    }

    [TestMethod()]
    public void HammingWeightStringTest()
    {
        var service = new NumberOfBits();

        var result = service.HammingWeightString(Convert.ToUInt32("00000000000000000000000000001011", 2));
        Assert.AreEqual(3, result);

        result = service.HammingWeightString(Convert.ToUInt32("00000000000000000000000010000000", 2));
        Assert.AreEqual(1, result);

        Assert.AreEqual(31, service.HammingWeightString(Convert.ToUInt32("11111111111111111111111111111101", 2)));

        var number = "10000000000000000000000000000000";
        Assert.AreEqual(1, service.HammingWeightString(Convert.ToUInt32("10000000000000000000000000000000", 2)));
    }
}