using System;
using System.Collections.Generic;
using System.Text;

namespace Trainv2
{

  /*
   +--------+
   | CartPt |
   +--------+
   | int x  |
   | int y  |
   +--------+

   */

  // to represent a Cartesian point
  public class CartPt
  {
    private int _x;
    private int _y;

    public int X { get; set; }
    public int Y { get; set; }

    public CartPt(int x, int y)
    {
      _x = x;
      _y = y;
    }

    // to compute the distance form this point to the origin
    public double distToOrigin()
    {
      return Math.Sqrt(_x * _x + _y * _y);
    }

    // to compute the distance form this point to the given point
    public double distTo(CartPt pt)
    {
      return Math.Sqrt((_x - pt._x) * (_x - pt._x) +
                       (_y - pt._y) * (_y - pt._y));
    }
  }
}
