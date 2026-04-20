using System;
using System.Windows.Forms;

// Обмен между Windows Forms из консольным приложением через ShowDialog() с DialogResult
// Обмен через ShowDialog() с DialogResult

namespace ConsoleAppThree
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine("Консоль: введите данные:");
         string consoleData = Console.ReadLine();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         using (var form = new MainForm($"Из консоли: {consoleData}"))
         {
            if (form.ShowDialog() == DialogResult.OK)
            {
               Console.WriteLine($"Консоль: из формы: {form.FormData}");
            }
         }
         Console.ReadKey();
      }
   }
}