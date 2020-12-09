namespace BookStore
{
  public class Books
  {
    private string _title;
    private int _price;
    private int _year;
    private string _authorname;

    public Books(string title, int price, int year, string authorname)
    {
      _title = title;
      _price = price;
      _year = year;
      _authorname = authorname;
    }
  }
}
