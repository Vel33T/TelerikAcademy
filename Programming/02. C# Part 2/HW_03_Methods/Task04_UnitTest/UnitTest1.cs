using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int result = NumberInArrayAppearances.Check(1);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int result = NumberInArrayAppearances.Check(2);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int result = NumberInArrayAppearances.Check(3);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int result = NumberInArrayAppearances.Check(4);
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void TestMethod5()
    {
        int result = NumberInArrayAppearances.Check(9);
        Assert.AreEqual(1, result);
    }
}
