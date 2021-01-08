namespace DrawingProgramv2
{
  public interface IShape
  {
    /// <summary>
    /// to compute the area of THIS shape
    /// </summary>
    /// <returns></returns>
    double area();
    /// <summary>
    /// to compute the distance of THIS shape to the origin
    /// </summary>
    /// <returns></returns>
    double distTo0();

  }
}
