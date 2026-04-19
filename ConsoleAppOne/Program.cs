using System;
using System.Windows.Forms;

// Демонстрация запуска Windows Forms из консольного приложения

namespace ConsoleAppOne
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine(@"Нажмите любую клавишу для запуска Windows Forms формы");
         Console.ReadKey();

         Console.WriteLine(@"Запуск Windows Forms из консольного приложения");

         // Включаем визуальные стили для современного вида элементов управления
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаем экземпляр формы
         MyForm form = new MyForm();

         // Запускаем стандартный цикл обработки сообщений Windows
         Application.Run(form);

         // Этот код выполнится только после закрытия формы
         Console.WriteLine(@"Нажмите любую клавишу для выхода...");
         Console.ReadKey();

      }
   }
}