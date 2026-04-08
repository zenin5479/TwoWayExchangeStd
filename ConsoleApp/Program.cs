using System;
using System.Diagnostics;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Запуск Windows Forms приложения...");

         Process formsApp = new Process();
         formsApp.StartInfo.FileName = "WinFormsApp.exe"; // Путь к Windows Forms приложению

         // Основные настройки для запуска GUI‑приложения
         formsApp.StartInfo.UseShellExecute = true; // Для GUI обычно true
         formsApp.StartInfo.CreateNoWindow = false;

         try
         {
            if (formsApp.Start())
            {
               Console.WriteLine("Windows Forms приложение запущено. PID: " + formsApp.Id);
               Console.WriteLine("Нажмите Enter для завершения...");
               Console.ReadLine();

               // Попытка завершить дочерний процесс
               if (!formsApp.HasExited)
               {
                  formsApp.CloseMainWindow();
                  if (!formsApp.WaitForExit(2000)) // Ждём 2 секунды
                  {
                     formsApp.Kill(); // Принудительное завершение, если не закрылось
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
         }
      }
   }
}