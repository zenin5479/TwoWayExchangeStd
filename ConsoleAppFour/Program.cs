using System;
using System.Windows.Forms;

namespace ConsoleAppFour
{
   internal class Program
   {
      [STAThread]
      static void Main(string[] args)
      {
         Console.WriteLine("Введите сообщение для формы:");
         string consoleData = Console.ReadLine();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Передаём данные из консоли в форму через конструктор
         Application.Run(new FormConstructor(consoleData));
      }
   }
}
