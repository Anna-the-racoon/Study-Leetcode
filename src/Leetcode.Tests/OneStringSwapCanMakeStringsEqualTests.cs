using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests;

[TestClass()]
public class OneStringSwapCanMakeStringsEqualTests
{
    [TestMethod()]
    public void AreAlmostEqualTest()
    {
        var service = new OneStringSwapCanMakeStringsEqual();

        Assert.AreEqual(true, service.AreAlmostEqual("bank", "kanb"));

        Assert.AreEqual(false, service.AreAlmostEqual("attack", "defend"));

        Assert.AreEqual(true, service.AreAlmostEqual("kelb", "kelb"));

        Assert.AreEqual(false, service.AreAlmostEqual("abcd", "dcba"));

        Assert.AreEqual(false, service.AreAlmostEqual("caa", "aaz"));

        Assert.AreEqual(false, service.AreAlmostEqual("npv", "zpn"));

        Assert.AreEqual(false, service.AreAlmostEqual("bankb", "kannb"));

        Assert.AreEqual(true, service.AreAlmostEqual("aaXaaaXaaaaBaaa", "aaXaaaBaaaaXaaa"));

        Assert.AreEqual(false, service.AreAlmostEqual("aaXaaaXaaaaZaaa", "aaXaaaBaaaaXaaa"));

        Assert.AreEqual(false, service.AreAlmostEqual("aaXaaaXaaaaBaaa", "aaXaaaBaaaaZaaa"));
    }
}