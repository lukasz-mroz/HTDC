using System;

namespace DrawingProgramv3
{
  public class CartPt
  {
    public int X { get; set; }
    public int Y { get; set; }

    public CartPt(int x, int y)
    {
      X = x;
      Y = y;
    }

    public double DistTo0()
    {
      throw new NotImplementedException();
    }
    public double DistTo(CartPt cart)
    {
      throw new NotImplementedException();
    }
  }
}