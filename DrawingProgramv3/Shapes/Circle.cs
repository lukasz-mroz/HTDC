namespace DrawingProgramv3
{
  public class Circle : Shape
  {
    private int _radius;
    public Circle(CartPt loc, int radius) : base(loc)
    {
      _radius = radius;
    }
  }
}
