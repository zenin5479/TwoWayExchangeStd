using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class DataForm : Form
   {
      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }

      public DataForm(string initialName)
      {
         InitializeComponent();

         greetingLabel.Text = string.Format("Привет, {0}!", initialName);

         //// Приветствие с переданным из консоли именем

         ////greetingLabel

         //Label greetingLabel = new Label
         //{
         //   Text = string.Format("Привет, {0}!", initialName)
         //};
      }

      //public DataForm()
      //{
         
      //}

      private void closeButton_Click(object sender, System.EventArgs e)
      {
         // Перед закрытием сохраняем данные в свойства
         UserAgreed = agreeCheckBox.Checked;
         UserComment = commentTextBox.Text;
         Close();
      }
   }
}