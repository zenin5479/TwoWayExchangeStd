using System;
using System.Windows.Forms;

// Обмен между Windows Forms и консольным приложением через ShowDialog() с DialogResult

namespace ConsoleAppThree
{
   internal class Program
   {
      [STAThread]
      static void Main()
      {
         Console.WriteLine(@"Консоль: введите данные:");
         string consoleData = Console.ReadLine();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         using (MainForm form = new MainForm(string.Format("Из консоли: {0}", consoleData)))
         {
            if (form.ShowDialog() == DialogResult.OK)
            {
               Console.WriteLine(@"Консоль: из формы: {0}", form.FormData);
            }
         }
         Console.ReadKey();
      }
   }
}