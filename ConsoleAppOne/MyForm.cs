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

      private void helloButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = string.Format(@"Московское время: {0:HH:mm:ss:fff}", DateTime.Now);
         Console.WriteLine(@"Московское время: {0:HH:mm:ss:fff}", DateTime.Now);
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         Close();
         Console.WriteLine(@"Форма закрыта. Консоль снова активна");
      }
   }
}