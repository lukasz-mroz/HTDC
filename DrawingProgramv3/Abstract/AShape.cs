namespace DrawingProgramv3
{
  abstract public class AShape : IShape
  {
    private CartPt _loc;


    public abstract double Area();
    public abstract double DistTo0();
    public abstract IShape Grow(int inc);
    public abstract bool BiggerThan(IShape that);
    public abstract bool Contains(CartPt pt);
  }
}