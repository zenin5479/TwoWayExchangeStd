using System;
using System.Windows.Forms;

namespace ConsoleAppThree
{
   public partial class MainForm : Form
   {
      // Свойство для хранения данных, которые будут переданы в консоль
      public string UserInput { get; private set; }

      public MainForm(string initialData)
      {
         InitializeComponent();
         messageLabel.Text = initialData;
      }

      private void okButton_Click(object sender, EventArgs e)
      {
         // Сохраняем данные перед закрытием
         UserInput = inputBox.Text;
         // Форма закроется автоматически, так как DialogResult уже установлен
         Close();
      }
   }
}