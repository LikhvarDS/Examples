using System;

namespace Delegates
{
  public delegate int SortingMethodInt(int[] nums);

  class Program
  {
    static void Main(string[] args)
    {
      // Делегат — это структура данных, описывающая сигнатуру метода;

      SortingMethodInt method = Program.SearchMaxInteger;

      int[] numbersArray = new int[] { 1, 2, 5, 3, 4 };
      var result = method(numbersArray);
      // or
      //var result = method?.Invoke(numbersArray);

      Console.WriteLine(result);
    }

    /*static void Main(string[] args)
    {
      // Каждый раз создавать делегаты - не удобно.
      // Уже существуют обобщённые делегаты!

      Func<int[], int> method = Program.SearchMaxInteger;

      int[] numbersArray = new int[] { 1, 2, 5, 3, 4 };
      var result = method(numbersArray);

      Console.WriteLine(result);
    }*/

    /*static void Main(string[] args)
    {
      // Объявлять методы - долго.
      // Занимает много места. + Не всегда бывает удобно их искать.

      // Есть анонимные методы!

      Func<int, int> increment1 = new Func<int, int>(delegate(int x) { return x + 1; });

      var result = increment1(1);
      Console.WriteLine(result);


      
      // Есть lambda!

      Func<int, int> increment2 = new Func<int, int>(x => x + 1);

      result = increment2(5);
      Console.WriteLine(result);



      Func<int, int> increment3 = x => x + 1;

      result = increment3(9);
      Console.WriteLine(result);
    }*/

    #region Methods

    public static int SearchMaxInteger(int[] nums)
    {
      int result = nums[0];

      for(int i = 1; i < nums.Length; i++)
      {
        if (nums[i] > result)
        {
          result = nums[i];
        }
      }

      return result;
    }

    #endregion
  }
}
