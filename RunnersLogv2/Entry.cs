namespace RunnersLogv2
{
  /// <summary>
  /// an entry in a runner's log
  /// </summary>
  public class Entry
  {
    private Date _d;
    private double _distance;
    private int _duration;
    private string _comment;

    public Entry(Date d, double distance, int duration, string comment)
    {
      _d = d;
      _distance = distance;
      _duration = duration;
      _comment = comment;
    }
  }
}
