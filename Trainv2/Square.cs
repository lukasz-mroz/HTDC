using System;
using System.Collections.Generic;
using System.Text;

namespace Trainv2
{
  // to represent a square
  public class Square : IShape
  {
    private CartPt _nw;
    private int _size;
    private string _color;

    public Square(CartPt nw, int size, string color) {
      _nw = nw;
      _size = size;
      _color = color;
    }

    /*
     // ** TEMPLATE ** 
     returnType methodName() {
     ... this.nw ...              -- CartPt
     ... this.size ...            -- int
     ... this.color ...           -- String
     
     ... this.area() ...                  -- double 
     ... this.distToOrigin() ...          -- double 
     ... this.grow(int inc) ...           -- IShape
     }
     */

    // to compute the area of this shape
  public double area()
  {
    return _size * _size;
  }

  // to compute the distance form this shape to the origin
  public double distToOrigin()
  {
    return _nw.distToOrigin();
  }

  // to increase the size of this shape by the given increment
  public IShape grow(int inc)
  {
    return new Square(_nw, _size + inc, _color);
  }

  // is the area of this shape bigger than the area of the given shape?
  public bool biggerThan(IShape that)
  {
    /*---------------------------------------------------
     // ** TEMPLATE ** 
     public returnType methodName() {
     ... this.nw ...                  -- CartPt
     ... this.size ...                -- int
     ... this.color ...               -- String

     ... this.area() ...                  -- double 
     ... this.distToOrigin() ...          -- double 
     ... this.grow(int inc) ...           -- IShape

     ... that.nw ...                  -- CartPt
     ... that.size ...                -- int
     ... that.color ...               -- String

     ... that.area() ...                  -- double 
     ... that.distToOrigin() ...          -- double 
     ... that.grow(int inc) ...           -- IShape
     ---------------------------------------------------*/
    return this.area() >= that.area();
  }

  // does this shape (including the boundary) contain the given point?
  public bool contains(CartPt pt)
  {
    /*---------------------------------------------------
     // ** TEMPLATE ** 
     public returnType methodName() {
     ... this.nw ...                  -- CartPt
     ... this.size ...                -- int
     ... this.color ...               -- String

     ... this.area() ...                  -- double 
     ... this.distToOrigin() ...          -- double 
     ... this.grow(int inc) ...           -- IShape

     ... this.nw.distToOrigin() ...       -- double
     ... this.nw.distTo(CartPt x) ...     -- double

     ... pt.distToOrigin() ...               -- double
     ... pt.distTo(CartPt x) ...             -- double
     ---------------------------------------------------*/
    return (_nw.X <= pt.X) && (pt.X <= _nw.X + _size) &&
    (_nw.Y <= pt.Y) && (pt.Y <= _nw.Y + _size);
  }
}
}
