namespace DrawingProgramv3
{
  /// <summary>
  /// to represent a square
  /// </summary>
  public class Square : IShape
  {
    private CartPt _nw;
    private int _size;
    private string _color;

    public Square(CartPt nw, int size, string color)
    {
      _nw = nw;
      _size = size;
      _color = color;
    }

    /// <summary>
    /// to compute area of this shape
    /// </summary>
    /// <returns></returns>
    public double Area() => _size * _size;

    public double DistTo0() => _nw.DistTo0();

    public IShape Grow(int inc) => new Square(_nw, _size + inc, _color);

    public bool BiggerThan(IShape that) => this.Area() >= that.Area();

    public bool Contains(CartPt pt)
    {
      return (_nw.X <= pt.X) && (pt.X <= _nw.X + _size) &&
             (_nw.Y <= pt.Y) && (pt.Y <= _nw.Y + _size);
    }
  }
}



