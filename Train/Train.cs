namespace Train
{
  public class Train
  {
    private Route _r;
    private Schedule _s;
    private bool _local;

    public Train(Route r, Schedule s, bool local)
    {
      _r = r;
      _s = s;
      _local = local;
    }
  }
}
