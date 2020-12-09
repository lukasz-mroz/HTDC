using System;

namespace BankAccount
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var boomer = new CD("hello", 30);
      var result = boomer.Interest();
      Console.WriteLine(result);
    }
  }
}
