namespace DrawingProgramv3
{
  public class Circle : IShape
  {
    private int _radius;
    public Circle(CartPt loc, int radius)
    {
      _radius = radius;
    }

    public double Area()
    {
      throw new System.NotImplementedException();
    }

    public double DistTo0()
    {
      throw new System.NotImplementedException();
    }

    public IShape Grow(int inc)
    {
      throw new System.NotImplementedException();
    }

    public bool BiggerThan(IShape that)
    {
      throw new System.NotImplementedException();
    }

    public bool Contains(CartPt pt)
    {
      throw new System.NotImplementedException();
    }
  }
}
