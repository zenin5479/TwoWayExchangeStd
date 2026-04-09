using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp
{
   internal class Program
   {
      static Process childProcess;
      static StreamWriter childInput;
      static StreamReader childOutput;

      static void Main()
      {
         Console.WriteLine("=== Console Host ===");
         StartChildProcess();

         // Основной цикл взаимодействия
         while (true)
         {
            Console.Write("Enter command (PING, TIME, EXIT): ");
            string command = Console.ReadLine();

            if (string.IsNullOrEmpty(command))
               continue;

            // Отправляем команду в stdin дочернего процесса
            childInput.WriteLine(command);
            childInput.Flush();

            if (command.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
            {
               // Ждём ответа "BYE" от формы
               string farewell = childOutput.ReadLine();
               Console.WriteLine($"[FORM] {farewell}");
               break;
            }

            // Синхронно читаем ответ из stdout формы
            string response = childOutput.ReadLine();
            Console.WriteLine($"[FORM] Response: {response}");
         }

         // Корректное завершение
         childProcess.WaitForExit(2000);
         if (!childProcess.HasExited)
            childProcess.Kill();

         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();
      }

      static void StartChildProcess()
      {
         var startInfo = new ProcessStartInfo
         {
            FileName = "WinFormsApp.exe",   // Укажите полный путь, если нужно
            UseShellExecute = false,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = false           // false — чтобы видеть окно формы
         };

         childProcess = new Process { StartInfo = startInfo };
         childProcess.Start();

         childInput = childProcess.StandardInput;
         childOutput = childProcess.StandardOutput;

         Console.WriteLine("Child process (Windows Forms) started.");
      }
   }
}