namespace BankAccount
{
  /// <summary>
  /// represents an saving account
  /// </summary>
  public class Saving
  {
    private int _id;
    private string _name;
    private int _minBalance;
    private int _interestRate;

    public Saving(int id, string name, int minBalance, int interestRate)
    {
      _id = id;
      _name = name;
      _minBalance = minBalance;
      _interestRate = interestRate;
    }
  }
}
