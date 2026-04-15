using System.Windows.Forms;

namespace ConsoleAppFour
{
   public partial class FormConstructor : Form
   {
      // Конструктор с параметром для приёма данных из консоли
      public FormConstructor(string initialMessage)
      {
         InitializeComponent();
         messageLabel.Text = string.Format(@"Получено из консоли: {0}", initialMessage);
      }
   }
}
