using System;
namespace DrawingProgramv2
{
  public class Rectangle : IShape
  {
    private CartPt _tlCorner;
    private int _width;
    private int _height;

    public Rectangle(CartPt tlCorner, int width, int height)
    {
      _tlCorner = tlCorner;
      _width = width;
      _height = height;
    }

    public double area()
    {
      return 0;
    }

    public double distTo0()
    {
      throw new NotImplementedException();
    }
  }
}
