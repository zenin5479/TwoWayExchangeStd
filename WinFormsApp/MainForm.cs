using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      private Label lblStatus;

      public MainForm()
      {
         try
         {
            InitializeComponent();
            Text = "Windows Forms приложение (запущено консолью)";
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;
            Visible = true; // Явное указание видимости
            BringToFront(); // Выводим на передний план
            Focus(); // Устанавливаем фокус

            Label lblStatus = new Label
            {
               Text = "Приложение успешно запущено!",
               Location = new Point(20, 20),
               AutoSize = true
            };
            Controls.Add(lblStatus);

            Button btnTest = new Button
            {
               Text = "Тест видимости",
               Location = new Point(20, 50),
               Size = new Size(120, 30)
            };
            btnTest.Click += (s, e) =>
            {
               MessageBox.Show("Форма видна и работает!");
            };
            Controls.Add(btnTest);
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Ошибка инициализации формы: {ex.Message}", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
         }
      }
   }
}