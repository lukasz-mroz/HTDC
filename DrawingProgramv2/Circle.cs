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
  }
}
