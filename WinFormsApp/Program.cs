using System;
using System.Windows.Forms;

namespace WinFormsApp
{
   internal static class Program
   {
      /// <summary>
      ///  The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // 1. Синхронно читаем команду из stdin (переданную от консольного приложения)
         string command = Console.ReadLine();
         string response = string.Empty;

         // 2. Обрабатываем команду
         if (command == "show")
         {
            response = "OK, showing form";
            // Показываем форму (главное окно)
            Application.Run(new MainForm());
         }
         else
         {
            response = $"Unknown command: {command}";
         }

         // 3. Отправляем ответ обратно в консоль (родитель прочитает его через stdout)
         Console.WriteLine(response);
         Console.Out.Flush();
      }
   }
}
