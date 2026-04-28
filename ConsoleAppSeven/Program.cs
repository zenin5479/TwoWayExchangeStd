using System;

// Двусторонний обмен данными между консолью и Windows Forms через глобальный класс‑хранилище

namespace ConsoleAppSeven
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine(@"Консольное приложение с Windows Forms");
         Console.WriteLine(@"1 — Ввести данные в консоли");
         Console.WriteLine(@"2 — Открыть редактор Windows Forms");
         Console.WriteLine(@"3 — Показать все данные");
         Console.WriteLine(@"0 — Выход");

         while (true)
         {
            Console.Write(@"Выберите действие: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
               EnterDataInConsole();
            }
            else if (choice == "2")
            {
               OpenWindowsFormsEditor();
            }
            else if (choice == "3")
            {
               ShowAllData();
            }
            else if (choice == "0")
            {
               return;
            }
            else
            {
               Console.WriteLine(@"Неверный выбор");
            }
         }
      }

      static void EnterDataInConsole()
      {
         Console.Write(@"Имя: ");
         string name = Console.ReadLine();

         Console.Write(@"Возраст: ");
         if (int.TryParse(Console.ReadLine(), out int age))
         {
            Console.Write(@"Email: ");
            string email = Console.ReadLine();

            GlobalDataStore.People.Add(new Person { Name = name, Age = age, Email = email });
            Console.WriteLine(@"Данные сохранены");
         }
         else
         {
            Console.WriteLine(@"Некорректный возраст");
         }
      }

      static void ShowAllData()
      {
         Console.WriteLine(@"Все данные");
         if (GlobalDataStore.People.Count == 0)
         {
            Console.WriteLine(@"Нет данных");
         }
         else
         {
            int i = 0;
            while (i < GlobalDataStore.People.Count)
            {
               Console.WriteLine(@"{0}. {1}", i + 1, GlobalDataStore.People[i]);
               i++;
            }
         }
      }

      static void OpenWindowsFormsEditor()
      {
         DataEditorForm form = new DataEditorForm();
         form.ShowDialog();
      }
   }
}