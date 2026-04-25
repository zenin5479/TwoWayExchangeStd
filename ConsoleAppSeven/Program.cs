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

      static void EnterDataInConsole()
      {
         Console.Write("Имя: ");
         var name = Console.ReadLine();

         Console.Write("Возраст: ");
         if (int.TryParse(Console.ReadLine(), out int age))
         {
            Console.Write("Email: ");
            var email = Console.ReadLine();

            GlobalDataStore.People.Add(new Person { Name = name, Age = age, Email = email });
            Console.WriteLine("Данные сохранены!");
         }
         else
         {
            Console.WriteLine("Некорректный возраст!");
         }
      }

      static void ShowAllData()
      {
         Console.WriteLine("\n--- Все данные ---");
         if (GlobalDataStore.People.Count == 0)
         {
            Console.WriteLine("Нет данных");
         }
         else
         {
            for (int i = 0; i < GlobalDataStore.People.Count; i++)
            {
               Console.WriteLine($"{i + 1}. {GlobalDataStore.People[i]}");
            }
         }
      }

      static void OpenWindowsFormsEditor()
      {
         var form = new DataEditorForm();
         form.ShowDialog();
      }
   }
}