using System;

// Двусторонний обмен через статическое поле ()

namespace ConsoleAppFive
{
   internal class Program
   {
      // Статическое поле для обмена данными
      public static string ReturnedData { get; set; } = "Нет данных";

      static void Main()
      {
         Console.WriteLine("Hello World!");
      }
   }
}