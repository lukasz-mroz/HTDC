namespace Restaurant
{
  /// <summary>
  /// adding a restaurant to a list
  /// </summary>
  public class ConsListing : ILoR
  {
    private Restuarant _first;
    private ILoR _rest;

    public ConsListing(Restuarant first, ILoR rest)
    {
      _first = first;
      _rest = rest;
    }
  }
}
