namespace RunnersLogv2
{
  /// <summary>
  /// adding an entry to a log
  /// </summary>
  public class ConsLog : ILog
  {
    private Entry _fst;
    private ILog _rst;

    public ConsLog(Entry fst, ILog rst)
    {
      _fst = fst;
      _rst = rst;
    }
  }
}
