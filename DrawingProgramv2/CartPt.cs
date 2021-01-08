using System;
namespace DrawingProgramv2
{
  public class CartPt : IShape
  {
    private int _x;
    private int _y;

    public CartPt(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public double area()
    {
      throw new System.NotImplementedException();
    }

    public double distTo0()
    {
      return Math.Sqrt((_x * _x) + (_y * _y));
    }
  }
}