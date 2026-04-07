using System;
using System.Diagnostics;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Process process = new Process
         {
            StartInfo = new ProcessStartInfo
            {
               FileName = "WinFormsApp.exe",
               UseShellExecute = false,
               RedirectStandardInput = true,
               RedirectStandardOutput = true
            }
         };
         process.Start();

         string input;
         do
         {
            Console.Write("Введите сообщение (или 'exit'): ");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
               continue;
            }

            // Отправляем запрос
            process.StandardInput.WriteLine(input);
            process.StandardInput.Flush();

            if (input.ToLower() == "exit")
            {
               break;
            }

            // Ждём ответ (блокирует консоль)
            string response = process.StandardOutput.ReadLine();
            Console.WriteLine($"Ответ WinForms: {response}");

         } while (true);

         process.WaitForExit(1000);
         if (!process.HasExited)
         {
            process.Kill();
         }
      }
   }
}