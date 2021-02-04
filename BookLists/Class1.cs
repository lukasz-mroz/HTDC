using System;
using System.Collections.Generic;
using System.Text;

namespace BookLists
{
  class MtLoBook : ILoBook
  {
    MtLoBook()
    {
      // nothing to do!
    }
    public double totalPrice()
    {
      return 0;
    }
    public int count()
    {
      return 0;
    }
    public ILoBook allBooksBefore(int year)
    {
      return this;
      // return new MtLoBook();
    }
    public ILoBook sortByPrice()
    {
      return this;
      // return new MtLoBook();
    }
    public ILoBook insert(Book b)
    {
      return new ConsLoBook(b, this);
    }
  }
}
