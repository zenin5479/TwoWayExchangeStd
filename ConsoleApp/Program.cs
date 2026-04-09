using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp
{
   internal class Program
   {
      static Process _childProcess;
      static StreamWriter _childInput;
      static StreamReader _childOutput;

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
            {
               continue;
            }

            // Отправляем команду в stdin дочернего процесса
            _childInput.WriteLine(command);
            _childInput.Flush();

            if (command.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
            {
               // Ждём ответа "BYE" от формы
               string farewell = _childOutput.ReadLine();
               Console.WriteLine($"[FORM] {farewell}");
               break;
            }

            // Синхронно читаем ответ из stdout формы
            string response = _childOutput.ReadLine();
            Console.WriteLine($"[FORM] Response: {response}");
         }

         // Корректное завершение
         _childProcess.WaitForExit(2000);
         if (!_childProcess.HasExited)
         {
            _childProcess.Kill();
         }

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

         _childProcess = new Process { StartInfo = startInfo };
         _childProcess.Start();

         _childInput = _childProcess.StandardInput;
         _childOutput = _childProcess.StandardOutput;

         Console.WriteLine("Child process (Windows Forms) started.");
      }
   }
}