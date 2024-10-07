using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests;

[TestClass()]
public class HappyNumberTests
{
    [TestMethod()]
    public void IsHappyTest()
    {
        var service = new HappyNumber();

        Assert.AreEqual(true, service.IsHappy(19));

        Assert.AreEqual(false, service.IsHappy(2));

        Assert.AreEqual(true, service.IsHappy(1));

    }
}