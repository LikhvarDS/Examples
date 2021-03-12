using System.Collections.Concurrent;

namespace ThreadsProject
{
  public class Example3Args
  {
    public int Start { get; set; }

    public int NumbersCount { get; set; }

    public ConcurrentBag<int> Result { get; set; }
  }
}
