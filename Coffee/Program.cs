using System;
using System.Collections.Generic;

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
      Coffeer c;
      c = new Coffeer("helol0", 40, 50);
      object o;
      o = c;

      var personell = new List<Coffeer>()
      {
        new Coffeer("kawa",40,50),
        new Coffeer("hellp",30,50)

      };

      var match = personell.Find((Coffeer p) => { return p.Price == 40; });
      personell.Capacity

    }
  }
}
