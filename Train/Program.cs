using System;

namespace Train
{
  class Program
  {
    static void Main(string[] args)
    {
      var train1 = new Train(new Route("New York", "Boston"), new Schedule(new ClockTime(23,50), new ClockTime(40,50)), true);
      train1.GetHashCode();
      var train2 = new Train(new Route("Chicago", "Warsaw"), new Schedule(new ClockTime(23, 50), new ClockTime(40, 50)), false);
      train2.GetHashCode();
    }
  }
}
