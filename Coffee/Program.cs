using System;

namespace Coffee
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Coffeer frappen = new Coffeer("frappe", 10, 3);
      var result = frappen.Cost();
      frappen.LighterThan(new Coffeer("americana", 12, 1));
      Console.WriteLine(result);
    }
  }
}
