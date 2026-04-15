using System;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleAppFour
{
   public partial class FormConstructor : Form
   {
      // Конструктор с параметром для приёма данных из консоли
      public FormConstructor(string initialMessage)
      {
         InitializeComponent();
         messageLabel.Text = $"Получено из консоли: {initialMessage}";
      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         // Сохраняем данные для последующего использования
         //Program.ReturnedData = inputBox.Text;
         Close();
      }
   }
}
