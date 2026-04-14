using System;
using System.Windows.Forms;

namespace ConsoleAppThree
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void helloButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = string.Format(@"Привет! Время: {0:HH:mm:ss}", DateTime.Now);
      }
   }
}