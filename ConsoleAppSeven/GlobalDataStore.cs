using System;
using System.Collections.Generic;
using System.Text;

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

      public override string ToString() => $"{Name}, {Age} лет, {Email}";
   }
}