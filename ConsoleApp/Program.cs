using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Запуск Windows Forms приложения...");

         // Путь к exe Windows Forms приложения (скомпилируйте его первым)
         string formExePath = "WinFormsApp.exe";

         Process formProcess = new Process
         {
            StartInfo = new ProcessStartInfo
            {
               FileName = formExePath,
               UseShellExecute = false,
               RedirectStandardInput = true,
               RedirectStandardOutput = true,
               CreateNoWindow = true   // не показываем окно консоли дочернего процесса
            }
         };

         formProcess.Start();

         // Отправляем команду в дочерний процесс
         formProcess.StandardInput.WriteLine("show");
         formProcess.StandardInput.Flush();
         Thread.Sleep(2000);

         // Синхронно читаем ответ от дочернего процесса
         string response = formProcess.StandardOutput.ReadLine();

         Console.WriteLine($"Response from WinForms: {response}");

         // Дожидаемся закрытия формы (пользователь закроет её вручную)
         formProcess.WaitForExit();
         Console.WriteLine("Form closed. Press any key to exit...");
         Console.ReadKey();
      }
   }
}