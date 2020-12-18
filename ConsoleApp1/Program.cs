using System;

namespace Restaurant
{
  class Program
  {
    static void Main(string[] args)
    {
      var ex1 = new Restuarant("La crepe", "French", "moderate", new Place(30, 30));
      var ex2 = new Restuarant("Das Bier", "German", "cheap", new Place(2, 86));
      var ex3 = new Restuarant("sun", "Chinese", "cheap", new Place(10, 113));

      ILoR mt = new MTListing();
      ILoR l1 = new ConsListing(ex1, mt);
      ILoR l2 = new ConsListing(ex2, mt);
      ILoR l3 = new ConsListing(ex3, mt);

      ILoR all = new ConsListing(ex1, new ConsListing(ex2, new ConsListing(ex3, mt)));

      Console.WriteLine("Hello World!");
    }
  }
}
