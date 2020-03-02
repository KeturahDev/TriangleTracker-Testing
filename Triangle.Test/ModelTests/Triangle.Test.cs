using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void isTriangle_SidesABLessThanOrEqualToC_True()
    {
      Assert.AreEqual(true, Tracker.isTriangle(3,4,5));
    }
  }
}