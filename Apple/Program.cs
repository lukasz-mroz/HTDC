using System;

namespace Apple
{
  class Program
  {
    static void Main(string[] args)
    {
      var japko = new Apple(30, 40);
      japko.GetHashCode();
      Console.WriteLine(japko);
    }
  }
}
