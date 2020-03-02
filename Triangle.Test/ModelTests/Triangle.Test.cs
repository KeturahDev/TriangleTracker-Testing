using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod] //istriangle
    public void isTriangle_SidesABLessThanOrEqualToC_True()
    {
      Assert.AreEqual(true, Tracker.isTriangle(3,4,5));
    }
    [TestMethod]
    public void isTriangle_SidesABLessThanOrEqualToC_False()
    {
      Assert.AreEqual(false, Tracker.isTriangle(22,4,5));
    }

    [TestMethod] //isEqualateral
    public void isEqualateral_AllSidesEqual_True()
    {
      Assert.AreEqual(true, Tracker.isEqualateral(3,3,3));
    }
    [TestMethod]
    public void isEqualateral_AllSidesEqual_False()
    {
      Assert.AreEqual(false, Tracker.isEqualateral(3,2,3));
    }

    [TestMethod] //isIsosceles
    public void isIsosceles_2SidesAreEqual_True()
    {
      Assert.AreEqual(true, Tracker.isIsosceles(3,3,1));
    }
    [TestMethod] 
    public void isIsosceles_2SidesAreEqual_False()
    {
      Assert.AreEqual(false, Tracker.isIsosceles(3,2,1));
    }

    [TestMethod] //isScalene
    public void isIsosceles_NoSidesEqual_True()
    {
      Assert.AreEqual(true, Tracker.isScalene(1,2,3));
    }
  }
}