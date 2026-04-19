using System;
using System.Windows.Forms;

// Демонстрация запуска Windows Forms из консольного приложения


// Демонстрация запуска Windows Forms из консольного приложения
// Переписать в ConsoleAppOne

namespace ConsoleAppOne
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine(@"Запуск Windows Forms из консольного приложения...");

         // Включаем визуальные стили для современного вида элементов управления
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаем экземпляр формы
         MyForm form = new MyForm();

         Console.WriteLine(@"Показываем форму. Закройте форму, чтобы завершить работу");

         // Запускаем стандартный цикл обработки сообщений Windows
         Application.Run(form);

         Console.WriteLine(@"Форма закрыта. Программа завершена");

         //

         //Console.WriteLine(@"Нажмите любую клавишу для запуска Windows Forms формы");
         //Console.ReadKey();

         //Console.WriteLine(@"Запуск Windows Forms...");

         //// Этот код выполнится только после закрытия формы
         //Console.WriteLine(@"Форма закрыта. Консоль снова активна!");
         //Console.WriteLine(@"Нажмите любую клавишу для выхода...");
         //Console.ReadKey();

      }
   }
}