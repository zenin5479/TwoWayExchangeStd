using System;
using System.Windows.Forms;

// Двусторонний обмен через публичные свойства
// 
// Форма → Консоль
// Демонстрация запуска Windows Forms из консольного приложения
// Способ 3. Через ShowDialog() с DialogResult (рекомендуемый для простых случаев)
// 

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