using System;
using System.Windows.Forms;

// Двусторонний обмен данными между консолью и Windows Forms через глобальный класс‑хранилище

namespace ConsoleAppSix
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine(@"Консоль с глобальным хранилищем");

         // Записываем начальные данные в хранилище
         Console.Write(@"Введите имя: ");
         DataStorage.UserName = Console.ReadLine();

         Console.Write(@"Введите возраст: ");
         if (int.TryParse(Console.ReadLine(), out int age))
         {
            DataStorage.UserAge = age;
         }

         DataStorage.Messages.Add("Данные введены из консоли");

         Console.WriteLine(@"Данные сохранены в хранилище. Запускаем форму");
         Console.WriteLine(@"Нажмите любую клавишу для запуска формы");
         Console.ReadKey();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new FormStorage());

         // После закрытия формы показываем финальные данные
         Console.WriteLine(@"Данные после работы формы ===");
         Console.WriteLine(@"Имя: {0}", DataStorage.UserName);
         Console.WriteLine(@"Возраст: {0}", DataStorage.UserAge);
         Console.WriteLine(@"Всего сообщений: {0}", DataStorage.Messages.Count);

         Console.WriteLine(@"Нажмите любую клавишу для выхода...");
         Console.ReadKey();
      }
   }
}