using System;

namespace ClassDevelopment2
{

  public interface IMoveable
  {
    void Move();
  }

  public abstract class Transport : IMoveable
  {
    public virtual void Move()
    {
      Console.WriteLine("Transport Move");
    }
  }

  public class Car : Transport
  {
    private readonly string color = "#000";

    public Car()
    {
      this.color = "#ffffff";
    }
  }

  public class Bike : Transport
  {
    public override void Move()
    {
      Console.WriteLine("Bike Move");
    }
  }


  public class Examples1
  {
    public const int MaxValue = 42;

    private int number;

    public int GetNumber()
    {
      return number;
    }

    public void SetNumber(int number)
    {
      this.number = number;
    }

    private string text;

    public string Text
    {
      get
      {
        return text + number.ToString();
      }
      set
      {
        if (/*валидация*/ true)
          text = value;
      }
    }

    public string Text2 { get; set; }



    private int privateField;

    protected int PropertyForChildren { get; }

    private protected int PropertyForChildrenInAssembly { get; set; }

    internal int PropertyForAssembly { get; }

    protected internal int PropertyForChildrenAndAssembly { get; set; }

    public int PropertyForEveryone { get; set; }
  }
}