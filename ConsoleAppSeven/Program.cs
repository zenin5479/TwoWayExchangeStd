using System;

namespace ConsoleAppSeven
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Консольное приложение с Windows Forms");
         Console.WriteLine("1 — Ввести данные в консоли");
         Console.WriteLine("2 — Открыть редактор Windows Forms");
         Console.WriteLine("3 — Показать все данные");
         Console.WriteLine("0 — Выход");

         while (true)
         {
            Console.Write("\nВыберите действие: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
               case "1":
                  EnterDataInConsole();
                  break;
               case "2":
                  OpenWindowsFormsEditor();
                  break;
               case "3":
                  ShowAllData();
                  break;
               case "0":
                  return;
               default:
                  Console.WriteLine("Неверный выбор!");
                  break;
            }
         }
      }
   }
}