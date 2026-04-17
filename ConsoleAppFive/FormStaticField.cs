using System.Windows.Forms;

namespace ConsoleAppFive
{
   public partial class FormStaticField : Form
   {
      public FormStaticField(string initialMessage)
      {
         InitializeComponent();
         messageLabel.Text = string.Format(@"Получено из консоли: {0}", initialMessage);
      }

      private void returnButton_Click(object sender, System.EventArgs e)
      {
         // Сохраняем данные для последующего использования
         Program.ReturnedData = inputBox.Text;
         Close();
      }
   }
}