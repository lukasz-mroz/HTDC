namespace ZooKeeper
{
  public class Lion : IZooAnimal
  {
    private int _meat;
    private string _name;
    private int _weight;

    public Lion(string name, int meat, int weight)
    {
      _name = name;
      _meat = meat;
      _weight = weight;
    }

    public string takao()
    {
      throw new System.NotImplementedException();
    }
  }

}
