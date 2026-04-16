using System;

// Способ 2. Через статическое поле (двусторонний обмен)



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