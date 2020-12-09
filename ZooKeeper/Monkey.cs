namespace ZooKeeper
{
  public class Monkey : IZooAnimal
  {
    private string _food;
    private string _name;
    private int _weight;

    public Monkey(string food, string name, int weight)
    {
      _food = food;
      _name = name;
      _weight = weight;
    }

    public string takao()
    {
      throw new System.NotImplementedException();
    }
  }

}
