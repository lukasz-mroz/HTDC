namespace Restaurant
{
  public class Restuarant
  {
    private string _name;
    private string _kind;
    private string _pricing;
    private Place _place;


    public Restuarant(string name, string kind, string pricing, Place place)
    {
      _name = name;
      _kind = kind;
      _pricing = pricing;
      _place = place;
    }
  }
}
