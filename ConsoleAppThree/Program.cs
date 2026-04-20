using System;
using System.Windows.Forms;

// Обмен между Windows Forms из консольным приложением через ShowDialog() с DialogResult

namespace ConsoleAppThree
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine(@"Консольное приложение запущено...");
         Console.WriteLine(@"Нажмите любую клавишу для запуска Windows Forms формы");
         Console.ReadKey();

         Console.WriteLine(@"Запуск Windows Forms...");

         // Включаем визуальные стили
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаём и запускаем форму
         Application.Run(new MainForm());

         // Этот код выполнится только после закрытия формы
         Console.WriteLine(@"Форма закрыта. Консоль снова активна!");
         Console.WriteLine(@"Нажмите любую клавишу для выхода...");
         Console.ReadKey();
      }
   }
}