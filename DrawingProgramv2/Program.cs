using System;


namespace DrawingProgramv2
{
  partial class Program
  {
    static void Main(string[] args)
    {
      IShape s = new Square(new CartPt(30, 40), 40);
      IShape d = new Circle(new CartPt(30, 40), 30);
      var result = s.area();
      var result2 = d.area();
      var result3 = d.distTo0();
      var result4 = s.distTo0();
      Console.WriteLine(result);
      Console.WriteLine(result2);
      Console.WriteLine(result3);
      Console.WriteLine(result4);
      IShape c = new Rectangle(new CartPt(30, 40), 30, 30);
      c.area();
      d.distTo0();

    }
  }
}
