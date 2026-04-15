using System;
using System.Windows.Forms;

// Передача данных из консоли в форму через конструктор формы 

namespace ConsoleAppFour
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine("Введите текст для отображения в форме:");
         string userInput = Console.ReadLine();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm(userInput));

         Console.WriteLine("Работа завершена. Нажмите любую клавишу...");
         Console.ReadKey();
      }
   }
}