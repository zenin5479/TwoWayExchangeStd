using System;
using System.Windows.Forms;


// Двусторонний обмен через статическое поле

namespace ConsoleAppFive
{
   internal class Program
   {
      // Статическое поле для обмена данными
      public static string ReturnedData { get; set; } = "Нет данных";

      [STAThread]
      static void Main()
      {
         Console.WriteLine(@"Консоль: введите данные для формы:");
         string consoleInput = Console.ReadLine();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new FormStaticField(consoleInput));

         // После закрытия формы читаем данные
         Console.WriteLine(@"Консоль: получено из формы: {0}", ReturnedData);
         Console.ReadKey();
      }
   }
}