namespace DrawingProgramv3
{
  public class Shape : IShape
  {
    private CartPt _loc;

    public Shape(CartPt loc)
    {
      _loc = loc;
    }
  }
}