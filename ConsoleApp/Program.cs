using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Запуск Windows Forms приложения...");

         string formsAppPath = "WinFormsApp.exe";

         if (!File.Exists(formsAppPath))
         {
            Console.WriteLine($"Ошибка: Файл '{formsAppPath}' не найден!");
            Console.WriteLine($"Текущая директория: {Directory.GetCurrentDirectory()}");
            Console.ReadLine();
            return;
         }

         Process formsApp = new Process();
         formsApp.StartInfo.FileName = formsAppPath;
         formsApp.StartInfo.UseShellExecute = true;
         formsApp.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
         formsApp.StartInfo.CreateNoWindow = false;

         try
         {
            if (formsApp.Start())
            {
               Console.WriteLine($"Windows Forms приложение запущено. PID: {formsApp.Id}");

               // Ждём завершения процесса
               formsApp.WaitForExit();
               Console.WriteLine("Windows Forms приложение завершено.");
            }
            else
            {
               Console.WriteLine("Не удалось запустить Windows Forms приложение");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Ошибка при запуске: {ex.Message}");
         }
      }
   }
}