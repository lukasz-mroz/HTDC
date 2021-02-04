using System.Diagnostics.CodeAnalysis;

namespace DrawingProgramv3
{
  public class Rectangle : IShape
  {
    private CartPt _nw;
    private int _width;
    private int _height;
    private string _color;


    public Rectangle(CartPt nw, int width, int height, string color)
    {
      _nw = nw;
      _width = width;
      _height = height;
      _color = color;
    }

    public double Area() => _width + _height;

    public double DistTo0() => _nw.DistTo0();

    public IShape Grow(int inc) => new Rectangle(_nw, _width,_height,_color);

    public bool BiggerThan(IShape that) => this.Area() >= that.Area();

    public bool Contains(CartPt pt)
    {
      return (_nw.X <= pt.X) && (pt.X <= _nw.X + _width) &&
             (_nw.Y <= pt.Y) && (pt.Y <= _nw.Y + _height);

    }
  }
}