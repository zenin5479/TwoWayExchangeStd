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

         string formsAppPath = "WindowsFormsApp.exe";

         // Проверка существования файла
         if (!File.Exists(formsAppPath))
         {
            Console.WriteLine($"Ошибка: Файл '{formsAppPath}' не найден!");
            Console.WriteLine($"Текущая директория: {Directory.GetCurrentDirectory()}");
            Console.WriteLine("Убедитесь, что Windows Forms приложение скомпилировано и находится в той же папке.");
            Console.ReadLine();
            return;
         }

         Process formsApp = new Process();
         formsApp.StartInfo.FileName = formsAppPath;
         formsApp.StartInfo.UseShellExecute = true;
         formsApp.StartInfo.CreateNoWindow = false;
         formsApp.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

         try
         {
            if (formsApp.Start())
            {
               Console.WriteLine($"Windows Forms приложение запущено. PID: {formsApp.Id}");
               Console.WriteLine("Нажмите Enter для завершения...");
               Console.ReadLine();

               // Попытка корректно закрыть приложение
               if (!formsApp.HasExited)
               {
                  formsApp.CloseMainWindow();
                  if (!formsApp.WaitForExit(2000))
                  {
                     formsApp.Kill();
                  }
               }
            }
            else
            {
               Console.WriteLine("Не удалось запустить Windows Forms приложение");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Ошибка при запуске: {ex.Message}");
            if (ex is System.ComponentModel.Win32Exception win32Ex)
            {
               Console.WriteLine($"Win32Error: {win32Ex.NativeErrorCode}");
            }
         }
      }
   }
}