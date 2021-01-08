using System;

namespace MicroC
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class ScreenPosition
  {
    public int x;
    public int y;

    public ScreenPosition(int x, int y)
    {
      this.x = rangeCheckedX(x);
      this.y = rangeCheckedX(y);
    }

    private static int rangeCheckedX(int x)
    {
      if( x<0 || x > 1279)
      {
        throw new ArgumentOutOfRangeException("X");
      }
      return x;
    }
    private static int rangeCheckedY(int y)
    {
      if (y < 0 || y > 1023)
      {
        throw new ArgumentOutOfRangeException("Y");
      }
      return y;
    }
  }
}
