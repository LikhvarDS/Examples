using System;

namespace Lambda
{
  public delegate int SortingMethodInt(int x, int y);

  public class Program
  {
    public static void Main()
    {
      // Делегат:
      SortingMethodInt method = Program.Sum;

      int? result = method(1, 2);
      // or
      result = method?.Invoke(1, 2);

      Console.WriteLine(result);
      Console.WriteLine();
      Console.ReadKey();

      // Локальная функция:
      int localSumFunction(int i, int j)
      {
        return i + j;
      }

      result = localSumFunction(3, 4);
      Console.WriteLine(result);
      Console.WriteLine();
      Console.ReadKey();

      // Анонимный метод:
      Func<int, int, int> anonMethod = delegate (int x, int y)
      {
        return x + y;
      };

      result = anonMethod?.Invoke(5, 6);
      Console.WriteLine(result);
      Console.WriteLine();
      Console.ReadKey();

      // Lambda:
      Func<int, int, int> lamda = (x, y) => x + y;
      result = lamda?.Invoke(7, 8);
      Console.WriteLine(result);
      Console.ReadKey();
    }



    public static int Sum(int i, int j)
    {
      return i + j;
    }
  }
}
