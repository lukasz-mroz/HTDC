using System;

namespace GPS
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class GPS
  {
    private double _latitude;
    private double _longitude;

    public GPS(double latitude, double longitude)
    {
      _latitude = latitude;
      _longitude = longitude;
    }
  }
}
