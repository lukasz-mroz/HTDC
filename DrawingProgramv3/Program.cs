using System;

namespace DrawingProgramv3
{
  partial class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      IShape shanky = new Circle(new CartPt(30, 40), 30);
      var result = shanky.GetHashCode();
      Console.WriteLine(result);
    }
  }
}
