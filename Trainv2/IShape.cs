using System;
using System.Collections.Generic;
using System.Text;

namespace Trainv2
{
  // to represent a geometric shape
  public interface IShape
  {
    // to compute the area of this shape
    double area();

    // to compute the distance form this shape to the origin
    double distToOrigin();

    // to increase the size of this shape by the given increment
    IShape grow(int inc);

    // is the area of this shape bigger than the area of the given shape?
    bool biggerThan(IShape that);

    // does this shape (including the boundary) contain the given point?
    bool contains(CartPt pt);
  }
}
