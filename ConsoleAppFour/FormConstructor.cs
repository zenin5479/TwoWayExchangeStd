using System.Windows.Forms;
using System.Drawing;

namespace ConsoleAppFour
{
   public partial class FormConstructor : Form
   {
      // Конструктор с параметром для приёма данных из консоли
      public FormConstructor(string initialMessage)
      {
         InitializeComponent();
         messageLabel.Text = $"Получено из консоли: {initialMessage}";
      }
   }
}
