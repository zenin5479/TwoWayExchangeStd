using System;
using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class MyForm : Form
   {
      public MyForm()
      {
         InitializeComponent();
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         Close();
         Console.WriteLine(@"Форма закрыта. Консоль снова активна");
      }

      private void helloButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = string.Format(@"Время: {0:HH:mm:ss}", DateTime.Now);
      }
   }
}