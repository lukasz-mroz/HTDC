using System;
namespace ZooKeeper
{
  public class Snake : IZooAnimal
  {
    private int _length;
    private string _name;
    private int _weight;

    public Snake(int length, string name, int weight)
    {
      _length = length;
      _name = name;
      _weight = weight;
    }

    public string takao()
    {
      throw new NotImplementedException();
    }
  }
}
