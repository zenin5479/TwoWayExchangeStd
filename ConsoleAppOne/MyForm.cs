using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class MyForm : Form
   {
      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }

      public MyForm()
      {
         InitializeComponent();
      }

      private void closeButton_Click(object sender, System.EventArgs e)
      {
        
         Close();
      }
   }
}