using System;
using System.Collections.Generic;
using System.Text;

namespace BookLists
{
  interface ILoBook
  {
    // to compute the total price of all books in this list of books
    double totalPrice();
    // to count how many books are in this list of books
    int count();
    // to return a list of all the books in this list of books 
    // published before the given year
    ILoBook allBooksBefore(int year);
    // to construct a list of books that contains the same books as
    // this list of books, but sorted increasing by price
    ILoBook sortByPrice();
    ILoBook insert(Book b);
  }
}
