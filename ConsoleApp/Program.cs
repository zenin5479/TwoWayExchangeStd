using System;
using System.Windows.Forms;


namespace ConsoleApp
{
   internal class Program
   {
      [STAThread] // Обязательный атрибут для работы Windows Forms
      static void Main(string[] args)
      {
         Console.WriteLine("Запуск Windows Forms из консольного приложения...");

         // Включаем визуальные стили для современного вида элементов управления
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаем экземпляр формы
         var form = new MyForm();

         Console.WriteLine("Показываем форму. Закройте форму, чтобы завершить работу.");

         // Запускаем стандартный цикл обработки сообщений Windows
         Application.Run(form);

         Console.WriteLine("Форма закрыта. Программа завершена.");
      }
   }

   // Определение простой формы
   public class MyForm : Form
   {
      private Button _closeButton;

      public MyForm()
      {
         // Настройка формы
         this.Text = "Моя форма из консоли";
         this.Width = 300;
         this.Height = 200;

         // Создание кнопки
         _closeButton = new Button();
         _closeButton.Text = "Закрыть";
         _closeButton.Location = new System.Drawing.Point(100, 70);
         _closeButton.Click += (sender, e) => { this.Close(); };

         // Добавление кнопки на форму
         this.Controls.Add(_closeButton);
      }
   }
}