using System;

namespace Coffee
{
  class Program
  {
    static void Main(string[] args)
    {
      Coffeer america = new Coffeer("americana", 12, 1);
      Coffeer frappen = new Coffeer("frappe", 10, 3);
      var result = frappen.Cost();
      frappen.LighterThan(america);
      Console.WriteLine(result);
    }
  }
}
