namespace RunnersLogv2
{
  /// <summary>
  /// calendar dates
  /// </summary>
  public class Date
  {
    private int _day, _hello;
    private int _month;
    private int _year;

    public Date(int day, int month, int year)
    {
      _day = day;
      _month = month;
      _year = year;
    }
  }
  public abstract class Hello : ILog
  {
    private int _inter;

  }
}