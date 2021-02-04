using System;

namespace BookLists
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }


  import tester.*;




  /*
   * GOAL:
   * Represent a bunch of books, and be able to compute
   * - their total price
   * - how many books we have
   * - all the books published before the given year
   * - a sorted list of books
   */

  /*
   * A list of books is one of
   * empty
   * (cons book list-of-books)
   */

  // DYNAMIC DISPATCH: deciding which method definition to invoke (in which class)
  // based on the information available at runtime of the object that's invoking
  // the method

  
  




class ExamplesBooks
{
  Book htdp = new Book("HtDP", "MF", 0.0, 2014);
  Book hp = new Book("HP & the search for more money", "JKR", 9000.00, 2015);
  Book gatsby = new Book("The Great Gatsby", "FSF", 15.99, 1930);
  ILoBook mtList = new MtLoBook();
  ILoBook twoBooks = new ConsLoBook(this.htdp,
                         new ConsLoBook(this.hp,
                             this.mtList));
  ILoBook threeBooks = new ConsLoBook(this.gatsby, this.twoBooks);
}











}
