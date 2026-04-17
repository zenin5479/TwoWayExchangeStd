using System.Windows.Forms;

namespace ConsoleAppFive
{
   public partial class FormStaticField : Form
   {
      public FormStaticField(string initialMessage)
      {
         InitializeComponent();
      }

      private void returnButton_Click(object sender, System.EventArgs e)
      {
         // Сохраняем данные для последующего использования
         //Program.ReturnedData = inputBox.Text;
         this.Close();
      }
   }
}