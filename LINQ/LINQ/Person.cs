using System.Collections.Generic;

namespace LINQ
{
  public class Person
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }


    public static IEnumerable<Person> CreateTestData()
    {
      return new List<Person>()
      {
        new Person() { Id = 0, Age = 18, Name ="Иванов" },
        new Person() { Id = 1, Age = 6, Name ="Петров" },
        new Person() { Id = 2, Age = 18, Name ="Петров" },
        new Person() { Id = 3, Age = 18, Name ="Сидоров" },
        new Person() { Id = 4, Age = 13, Name ="Агатов" },
        new Person() { Id = 5, Age = 19, Name ="Бобров" },
        new Person() { Id = 6, Age = 21, Name ="Карлов" },
        new Person() { Id = 7, Age = 40, Name ="Викторов" },
        new Person() { Id = 8, Age = 18, Name ="Летов" },
        new Person() { Id = 9, Age = 24, Name ="Горшков" }
      };
    }
  }
}
