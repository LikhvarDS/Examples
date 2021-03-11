using System;

namespace ReferenceAndValueTypes
{
  public class Program
  {
    public static Person person1;
    public static void Main(string[] args)
    {
      var person = new Person();
      person.Name = "Anna";

      ChangeName(person, "Elizabeth");

      Console.WriteLine($"Person name is {person.Name}");

      //also int is structure System.Int32

    }

    public static void ChangeName(Person somebody, string newName)
    {
      somebody.Name = newName;
    }
  }
  
  //public class Person
  public struct Person 
  {
    public string Name { get; set; }

  }
}
