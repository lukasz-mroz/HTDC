using System;

namespace RunnersLog
{
  class Program
  {
    static void Main(string[] args)
    {
      var myBook2 = new Entry(new Date(30, 40, 2003), 23.4, 30, "hello"); ;
      myBook2.GetHashCode();
      Console.WriteLine("Hello World!");
    }
  }


  // A Log is one of:
  // - empty
  // - 
}
