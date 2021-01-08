using System;

namespace DrawingProgramv2
{
  /// <summary>
  /// a circle shape
  /// </summary>
   public class Circle : IShape
  {
    private CartPt _loc;
    private int _radius;

    public Circle(CartPt loc, int radius)
    {
      _loc = loc;
      _radius = radius;
    }

    public double area()
    {
      return (Math.PI * _radius * _radius);
    }

    public double distTo0()
    {
      return _loc.distTo0() - _radius;
    }
  }
 }

