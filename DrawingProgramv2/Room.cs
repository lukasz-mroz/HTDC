namespace DrawingProgramv2
{
  public class Room
  {
    //private int _width;
    //private int _height;
    private readonly int _width;
    private const int HEIGHT = 5;
    private static int depth;

    private IShape _a;
    private IShape _b;
    private IShape _c;


    public int Width { get; set; }
    public int Height { get; set; }

    public Room(int width, int height, IShape a, IShape b, IShape c, int asd)
    {
      Width = width;
      Height = height;
      _a = a;
      _b = b;
      _c = c;
      _width = asd;
    }
    ///// <summary>
    /// the ration of area covered by furniture in THIS room
    /// </summary>
    /// <returns></returns>
    public double Covered()
    {
      return (_a.area() + _b.area() + _c.area()) / (Width * Height);
    }
  }
} 