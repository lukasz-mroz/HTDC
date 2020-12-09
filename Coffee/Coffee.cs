using System;
namespace Coffee
{
  public class Coffeer
  {
    private string _kind;
    private int _price; // zł per kilo
    private int _weight; // kilograms

    public Coffeer(string kind, int price, int weight)
    {
      _kind = kind;
      _price = price;
      _weight = weight;
    }

    /// <summary>
    /// to compute the total cost of this coffe purchase
    /// </summary>
    /// <returns>int</returns>
    public int Cost()
    {
      return _price * _weight;
    }
    public bool MoreCents(int amt)
    {
      return _price > amt;
    }

    
    public bool LighterThan(Coffeer that)
    {
      return _weight < that._weight;
    }
  }
}
