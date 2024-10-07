using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests;

[TestClass()]
public class NearestPointTests
{
    [TestMethod()]
    public void NearestValidPointTest()
    {
        var service = new NearestPoint();

        int[][] arrayOne = { [1, 2], [3, 1], [2, 4], [2, 3], [4, 4] };
        Assert.AreEqual(2, service.NearestValidPoint(3, 4, arrayOne));

        int[][] arrayTwo = { [3, 4] };
        Assert.AreEqual(0, service.NearestValidPoint(3, 4, arrayTwo));

        int[][] arrayThree = { [2, 3] };
        Assert.AreEqual(-1, service.NearestValidPoint(3, 4, arrayThree));
    }
}