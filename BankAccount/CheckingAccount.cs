namespace BankAccount
{
  /// <summary>
  /// represents an CheckingAccount
  /// </summary>
  public class CheckingAccount
  {
    private int _id;
    private string _name;
    private int _minimumBalance;

    public CheckingAccount(int id, string name, int minimumBalance)
    {
      _id = id;
      _name = name;
      _minimumBalance = minimumBalance;
    }
  }
}
