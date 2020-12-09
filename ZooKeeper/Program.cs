using System;

namespace ZooKeeper
{
  class Program
  {
    static void Main(string[] args)
    {
      Lion leo = new Lion("Leo", 300, 5);
      leo.GetHashCode();
      IZooAnimal mana = new Monkey("banana", "bambus", 300);
      mana.GetHashCode();
    }
  }
}
