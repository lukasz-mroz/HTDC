using System;
using System.Collections.Generic;

namespace DrawingProgramv3
{
  partial class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      IShape shanky = new Circle(new CartPt(30, 40), 30);
      IShape vas = new Square(new CartPt(30,40),50, "red");
      IShape dasd = new Circle(new CartPt(30,40),50 );
      var result1 = vas.Grow(30);
      Console.WriteLine(result1);
      List<string> asd = new List<string>();


      IShape r1 = new Rectangle(new CartPt(30,40),40,20,"green");
      r1.Area();
    }
  }
}
