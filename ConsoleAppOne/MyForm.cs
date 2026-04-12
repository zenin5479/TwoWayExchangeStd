using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class MyForm : Form
   {
      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }

      public MyForm(string initialName)
      {
         InitializeComponent();

         greetingLabel.Text = string.Format("Привет, {0}!", initialName);
      }

      private void closeButton_Click(object sender, System.EventArgs e)
      {
         // Перед закрытием сохраняем данные в свойства
         UserAgreed = agreeCheckBox.Checked;
         UserComment = commentTextBox.Text;
         Close();
      }
   }
}