using System;
using System.Collections.Generic;
using System.Text;

namespace Trainv2
{
  // to represent a circle
  public class Circle : IShape
  {
    private CartPt center;
    private int radius;
    private string color;

    public Circle(CartPt center, int radius, String color)
    {
      this.center = center;
      this.radius = radius;
      this.color = color;
    }

    /*
     // ** TEMPLATE ** 
     public returnType methodName() {
     ... this.center ...              -- CartPt
     ... this.radius ...              -- int
     ... this.color ...               -- String
     
     ... this.area() ...                  -- double 
     ... this.distToOrigin() ...          -- double 
     ... this.grow(int inc) ...           -- IShape
     ... this.biggerThan(IShape that) ... -- boolean
     ... this.contains(CartPt pt) ...     -- boolean
     */
    // to compute the area of this shape
    public double area()
    {
      return Math.PI * this.radius * this.radius;
    }

    // to compute the distance form this shape to the origin
    public double distToOrigin()
    {
      return this.center.distToOrigin() - this.radius;
    }

    // to increase the size of this shape by the given increment
    public IShape grow(int inc)
    {
      return new Circle(this.center, this.radius + inc, this.color);
    }

    // is the area of this shape bigger than the area of the given shape?
    public bool biggerThan(IShape that)
    {
      /*---------------------------------------------------
       // ** TEMPLATE ** 
       public returnType methodName() {
       ... this.center ...              -- CartPt
       ... this.radius ...              -- int
       ... this.color ...               -- String

       ... this.area() ...                  -- double 
       ... this.distToOrigin() ...          -- double 
       ... this.grow(int inc) ...           -- IShape

       ... that.center ...              -- CartPt
       ... that.radius ...              -- int
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
       ... this.center ...              -- CartPt
       ... this.radius ...              -- int
       ... this.color ...               -- String

       ... this.area() ...                  -- double 
       ... this.distToOrigin() ...          -- double 
       ... this.grow(int inc) ...           -- IShape

       ... this.center.distToOrigin() ...      -- double
       ... this.center.distTo(CartPt x) ...    -- double

       ... pt.distToOrigin() ...               -- double
       ... pt.distTo(CartPt x) ...             -- double
       ---------------------------------------------------*/
      return this.center.distTo(pt) <= this.radius;
    }

  }
}
