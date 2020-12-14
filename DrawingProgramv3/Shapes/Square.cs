namespace DrawingProgramv3
{
  public class Square : Shape
  {
    private int _size;

    public Square(CartPt loc, int size) : base(loc)
    {
      _size = size;
    }
  }
}



