using System;

namespace Star
{
  class Program
  {
    static void Main(string[] args)
    {
      var gwazd = new Star(30);
      var result = gwazd.Drop();
      Console.WriteLine(result);
      Console.WriteLine("Hello World!");
    }
  }
  public class Star
  {
    private readonly int _X = 20;
    private int _y;
    private readonly int DELTA = 5;

    public Star(int y)
    {
      _y = y;
    }

    // TODO: Method for supercomputer
    public Star Drop()
    {
        if(_y + this.DELTA >= 100)
      {
        return new Star(100);
      }
      else
      {
        return new Star(_y + DELTA);
      }
    }
  }
}
