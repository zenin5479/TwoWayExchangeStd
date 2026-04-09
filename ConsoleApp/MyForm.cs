using System;
using System.Drawing;
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
         Text = "Моя форма из консоли";
         Width = 300;
         Height = 200;

         // Создание кнопки
         _closeButton = new Button();
         _closeButton.Text = "Закрыть";
         _closeButton.Location = new Point(100, 70);
         _closeButton.Click += OnCloseButtonOnClick;

         // Добавление кнопки на форму
         Controls.Add(_closeButton);
      }

      private void OnCloseButtonOnClick(object sender, EventArgs e)
      {
         Close();
      }
   }
}