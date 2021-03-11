using ClassDevelopment2;
using System;
using System.Collections.Generic;

namespace ClassDevelopment
{
  class Program
  {
    /// <summary>
    /// Пример 2.
    /// </summary>
    public static void Main()
    {
      IMoveable obj = new Car();
      obj.Move();
      obj = new Bike();
      obj.Move();

      /*var array = new int[5];
      var list = new List<int>();

      Sum(array);
      Sum(list);*/


      var array = new Transport[]
      {
        new Car(),
        new Bike()
      };
      MoveObject(obj);

      var examples = new Examples2();
      var message = examples.CallingMethod();
      Console.WriteLine(message);
    }

    public static int Sum(IEnumerable<int> collection)
    {
      int sum = 0;
      foreach (var element in collection)
        sum += element;

      return sum;
    }


    public static void MoveObject(IMoveable obj)
    {
      obj.Move();
    }
  }
}
