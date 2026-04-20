using System;
using System.Windows.Forms;

namespace ConsoleAppThree
{
   public partial class MainForm : Form
   {
      public string FormData { get; private set; }

      public MainForm(string initialData)
      {

         InitializeComponent();
         messageLabel.Text = initialData;
      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         // Сохраняем в свойство
         FormData = inputBox.Text;
         DialogResult = DialogResult.OK;
         this.Close();
      }
   }
}