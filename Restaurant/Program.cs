using System;

namespace Restaurant
{
  class Program
  {
    static void Main(string[] args)
    {
      var ex1 = new Restuarant("La crepe", "French", "moderate", new Place(30, 30));
      Console.WriteLine("Hello World!");
    }
  }
}
