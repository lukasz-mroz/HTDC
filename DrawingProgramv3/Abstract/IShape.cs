using System;

namespace DrawingProgramv3
{
  public interface IShape
  {
    double Area();
    double DistTo0();
    IShape Grow(int inc);
    bool BiggerThan(IShape that);
    bool Contains(CartPt pt);
  }
}