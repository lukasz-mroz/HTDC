using System;
namespace BankAccount
{
  public class CD
  {
    private string _owner;
    private int _amount;

    public CD(string owner, int amount)
    {
      _owner = owner;
      _amount = amount;
    }

    //
    public double Interest()
    {
      if(0 <= _amount && _amount < 50000)
      {
        return 2.00 * _amount;
      }
      else
      {
        if (50000 <= _amount && _amount < 10000)
        {
          return 2.25 * _amount;
        }
        else
        {
          return 2.50 * _amount;
        }
      }
    }
    public double PayInterest()
    {
      return (this.Interest() * _amount) / 100;
    }
  }
}
