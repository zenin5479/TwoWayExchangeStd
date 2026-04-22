using System;

namespace ConsoleAppSix
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine("=== Консоль с глобальным хранилищем ===");

         // Записываем начальные данные в хранилище
         Console.Write("Введите имя: ");
         DataStorage.UserName = Console.ReadLine();

         Console.Write("Введите возраст: ");
         if (int.TryParse(Console.ReadLine(), out int age))
         {
            DataStorage.UserAge = age;
         }

         DataStorage.Messages.Add("Данные введены из консоли");

         Console.WriteLine("\nДанные сохранены в хранилище. Запускаем форму...");
         Console.WriteLine("Нажмите любую клавишу для запуска формы");
         Console.ReadKey();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm());

         // После закрытия формы показываем финальные данные
         Console.WriteLine("\n=== Данные после работы формы ===");
         Console.WriteLine($"Имя: {DataStorage.UserName}");
         Console.WriteLine($"Возраст: {DataStorage.UserAge}");
         Console.WriteLine($"Всего сообщений: {DataStorage.Messages.Count}");

         Console.WriteLine("\nНажмите любую клавишу для выхода...");
         Console.ReadKey();
      }
   }
}