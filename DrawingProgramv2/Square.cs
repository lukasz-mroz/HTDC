namespace DrawingProgramv2
{
  public class Square: IShape
  {
    private CartPt _loc;
    private int _size;

    public Square(CartPt loc, int size)
    {
      _loc = loc;
      _size = size;
    }
  }
}
