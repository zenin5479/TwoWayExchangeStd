using System.Windows.Forms;

namespace ConsoleApp
{

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