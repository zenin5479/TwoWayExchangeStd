using System;
using System.Windows.Forms;

namespace WinFormsApp
{
   internal static class Program
   {
      /// <summary>
      ///  The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         try
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
         }
         catch (Exception ex)
         {
            MessageBox.Show(string.Format("Критическая ошибка приложения: {0}", ex.Message),
               "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
