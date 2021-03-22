namespace ConsoleApp1
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading;
  using System.Threading.Tasks;

  public class ParallelFilter
  {
    private int currentTasksCount;
    private readonly int maxTasksCount;
    private readonly int minElementsPerTask;

    public ParallelFilter(int maxTasks, int minElementsPerTask)
    {
      this.maxTasksCount = maxTasks;
      this.minElementsPerTask = minElementsPerTask;
    }

    public IEnumerable<T> Search<T>(IEnumerable<T> collection, Func<T, bool> predicate)
    {
      return this.SearchAsync(collection, predicate).Result;
    }

    public async Task<IEnumerable<T>> SearchAsync<T>(IEnumerable<T> collection, Func<T, bool> predicate)
    {
      this.currentTasksCount = 0;
      return await this.SearchInternalAsync(collection, predicate).ConfigureAwait(false);
    }

    private async Task<IEnumerable<T>> SearchInternalAsync<T>(IEnumerable<T> collection, Func<T, bool> predicate)
    {
      var count = collection.Count();
      var halfCount = count / 2;
      if (halfCount > this.minElementsPerTask && currentTasksCount <= this.maxTasksCount)
      {
        var part1 = collection.Take(halfCount);
        Interlocked.Increment(ref this.currentTasksCount);
        var task1 = this.SearchInternalAsync(part1, predicate);

        var part2 = collection.Skip(halfCount);
        Interlocked.Increment(ref this.currentTasksCount);
        var task2 = this.SearchInternalAsync(part2, predicate);

        return await Task.WhenAll(task1, task2)
          .ContinueWith(parts => {
            Interlocked.Add(ref this.currentTasksCount, -2);
            return parts.Result.SelectMany(elements => elements);
          });
      }

      return collection.Where(predicate).ToArray();
    }
  }
}
