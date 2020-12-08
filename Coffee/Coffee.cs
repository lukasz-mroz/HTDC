namespace Coffee
{
  public class Coffee
  {
    private string _kind;
    private int _price; // zł per kilo
    private int _weight; // kilograms

    public Coffee(string kind, int price, int weight)
    {
      _kind = kind;
      _price = price;
      _weight = weight;
    }
  }
}
