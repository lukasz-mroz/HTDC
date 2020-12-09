using NUnit.Framework;
using Coffee;

namespace NUnitTestProject1
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    { 
      //arrange
      var america = new Coffeer("americana", 12, 1);
      var frapper = new Coffeer("frapper", 13, 3);
      

      // act
      var result = america.Cost();
      var result1 = america.MoreCents(30);
      var result3 = america.LighterThan(frapper);
      // assert
      Assert.AreEqual(12, result);
      Assert.AreEqual(false, result1);
      Assert.AreEqual(true, result3);
      Assert.AreEqual(america.Cost(), new Coffeer("helo", 13, 24));

    }
  }
}