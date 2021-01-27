using System;
using RestSharp;

namespace Trainv2
{
  class Program
  {
    static void Main(string[] args)
    {

      

      CartPt pt1 = new CartPt(0, 0);
      CartPt pt2 = new CartPt(3, 4);
      CartPt pt3 = new CartPt(7, 1);

      IShape c1 = new Circle(new CartPt(50, 50), 10, "red");
      IShape c2 = new Circle(new CartPt(50, 50), 30, "red");
      IShape c3 = new Circle(new CartPt(30, 100), 30, "blue");

      IShape s1 = new Square(new CartPt(50, 50), 30, "red");
      IShape s2 = new Square(new CartPt(50, 50), 50, "red");
      IShape s3 = new Square(new CartPt(20, 40), 10, "green");

      
      var result1 = pt1.distToOrigin();
      var result2 = c2.area();
      var result3 = s3.biggerThan(c3);
      var result4 = s3.grow(30);


      Console.WriteLine(result1);

    }

  }

}