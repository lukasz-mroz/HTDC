using System;
using System.Collections.Generic;
using System.Text;

namespace BookLists
{

  class Book
  {
    string name;
    string author;
    double price;
    public int Year { get; set; }
    Book(String name, String author, double price, int year)
    {
      this.name = name;
      this.author = author;
      this.price = price;
      this.Year = year;
    }
    double getPrice()
    {
      return this.price;
    }
    // to return the discounted price of this book given the discount rate 
    double discount(double rate)
    {
      return this.price - (rate * this.price);
    }
    // to return a new book with the same author and name as this book,
    // but with price discounted at the given rate
    Book discountedBook(double rate)
    {
      return new Book(this.name, this.author, this.discount(rate), Year);
    }
  }
}
