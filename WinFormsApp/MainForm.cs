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
            lblStatus.Text = "Приложение успешно запущено!";

            // Добавляем тестовую кнопку
            Button testButton = new Button
            {
               Text = "Тест",
               Location = new Point(12, 40),
               Size = new Size(100, 30)
            };
            testButton.Click += (s, e) =>
            {
               MessageBox.Show("Кнопка работает!");
            };
            Controls.Add(testButton);
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Ошибка инициализации формы: {ex.Message}", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
         }
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         DialogResult result = MessageBox.Show(
            ("Вы уверены, что хотите закрыть приложение?"),
            "Подтверждение закрытия",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
         if (result == DialogResult.No)
         {
            e.Cancel = true;
         }
      }
   }
}