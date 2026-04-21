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
         Console.WriteLine("Консоль: введите начальное сообщение для формы:");
         string consoleData = Console.ReadLine();

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаём форму с начальными данными
         using (var form = new MainForm($"Из консоли: {consoleData}"))
         {
            // Показываем форму как модальное окно
            DialogResult result = form.ShowDialog();

            // Код выполняется только после закрытия формы
            if (result == DialogResult.OK)
            {
               Console.WriteLine("Консоль: пользователь ввёл: {0}", form.UserInput);
            }
            else
            {
               Console.WriteLine("Консоль: форма закрыта без подтверждения");
            }
         }

         Console.WriteLine("Нажмите любую клавишу для выхода...");
         Console.ReadKey();
      }
   }
}