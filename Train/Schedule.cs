namespace Train
{
  public class Schedule
  {
    private ClockTime _departure;
    private ClockTime _arrival;

    public Schedule(ClockTime departure, ClockTime arrival)
    {
      _departure = departure;
      _arrival = arrival;
    }
  }
}
