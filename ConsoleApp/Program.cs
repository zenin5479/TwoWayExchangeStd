using System;
using System.Windows.Forms;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Запуск Windows Forms из консольного приложения...");

         // Включаем визуальные стили для современного вида элементов управления
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаем экземпляр формы
         MyForm form = new MyForm();

         Console.WriteLine("Показываем форму. Закройте форму, чтобы завершить работу");

         // Запускаем стандартный цикл обработки сообщений Windows
         Application.Run(form);

         Console.WriteLine("Форма закрыта. Программа завершена");
      }
   }
}