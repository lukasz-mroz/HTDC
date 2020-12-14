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
    /// <summary>
    /// to determine whether THIS coffee's price is more than amt
    /// </summary>
    /// <param name="amt"></param>
    /// <returns></returns>
    public bool MoreCents(int amt)
    {
      return _price > amt;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="that"></param>
    /// <returns></returns>
    public bool LighterThan(Coffeer that)
    {
      return _weight < that._weight;
    }
  }
}
