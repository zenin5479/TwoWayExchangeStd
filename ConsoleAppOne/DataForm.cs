using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class DataForm : Form
   {
      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }


      public DataForm()
      {
         InitializeComponent();
      }
   }
}
