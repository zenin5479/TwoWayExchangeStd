using System;
using System.Windows.Forms;
using WinFormsApp;


namespace ConsoleApp
{
   internal class Program
   {
      [STAThread] // Обязательный атрибут для работы Windows Forms
      static void Main(string[] args)
      {
         Console.WriteLine("Консольное приложение запущено.");
         Console.WriteLine("Открываем форму Windows Forms...");

         // Включение визуальных стилей (делает интерфейс современнее)
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Запуск приложения Windows Forms с нашей формой
         // Используем Run, чтобы запустить стандартный цикл сообщений
         Application.Run(new MainForm());

         // Этот код выполнится только после закрытия формы
         Console.WriteLine("Форма закрыта. Консольное приложение завершает работу.");
      }
   }
}