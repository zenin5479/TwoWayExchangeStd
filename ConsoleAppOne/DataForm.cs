using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class DataForm : Form
   {
      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }

      //public DataForm(string initialName)
      //{
      //   // Приветствие с переданным из консоли именем

      //   //greetingLabel

      //   Label greetingLabel = new Label
      //   {
      //      Text = string.Format("Привет, {0}!", initialName)
      //   };
      //}

      public DataForm()
      {
         InitializeComponent();
      }

      public DataForm(string userName)
      {
         throw new System.NotImplementedException();
      }
   }
}