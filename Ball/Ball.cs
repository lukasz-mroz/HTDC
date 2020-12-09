namespace Ball
{
  /// <summary>
  /// a moving balls on a pool table
  /// </summary>
  public class Ball
  {
    private int _x;
    private int _y;
    private const int RADIUS = 5;

    public Ball(int x, int y)
    {
      _x = x;
      _y = y;
    }
  }
}
