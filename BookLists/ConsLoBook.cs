using System;
using System.Collections.Generic;
using System.Text;

namespace BookLists
{
  class ConsLoBook : ILoBook
  {
    private Book _first;
    private ILoBook _rest;
    ConsLoBook(Book first, ILoBook rest)
    {
      _first = first;
      _rest = rest;
    }
    public double totalPrice()
    {
      /* Template:
       * FIELDS:
       * this.first -- Book
       * this.rest -- ILoBook
       * METHODS:
       * this.totalPrice() -- double
       * this.count() -- int
       * this.allBooksBefore(int) -- ILoBook
       * this.sortByPrice() -- ILoBook
       * METHODS OF FIELDS:
       * this.first.getPrice() -- double ****
       * this.first.discount(double) -- double
       * this.first.discountedBook(double) -- Book
       * this.rest.totalPrice() -- double  *****
       * this.rest.count() -- int
       * this.rest.allBooksBefore(int) -- ILoBook
       * this.rest.sortByPrice() -- ILoBook
       */
      return this.getPrice() + _rest.totalPrice();
    }
    public int count()
    {
      return 1 + _rest.count();
    }
    public ILoBook allBooksBefore(int year)
    {
      if (this.first.Year < year)
      {
        return new ConsLoBook(
            this.first,
            this.rest.allBooksBefore(year));
      }
      else
      {
        return this.rest.allBooksBefore(year);
      }
    }
    public ILoBook sortByPrice()
    {
      /*
       * Assuming we have:
       * ILoBook insert(Book) -- on cons? on ilobook?
       * boolean isCheaper(Book) -- on Book
       */

      return this.rest.sortByPrice().insert(this.first);
    }
    // to insert the given book into this sorted list of books 
    public ILoBook Insert(Book b)
    {
      if (b.getPrice() < this.first.getPrice())
      {
        return new ConsLoBook(b, this);
      }
      else
      {
        return new ConsLoBook(this.first, this.rest.insert(b));
      }
    }
  }

}
