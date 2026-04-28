using System.Collections.Generic;

namespace ConsoleAppSeven
{
   public class GlobalDataStore
   {
      public static List<Person> People { get; } = new List<Person>();
   }

   public class Person
   {
      public string Name { get; set; }
      public int Age { get; set; }
      public string Email { get; set; }

      public override string ToString()
      {
         return string.Format("Имя: {0}, {1} лет, {2}", Name, Age, Email);
      }
   }
}