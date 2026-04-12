using System.Windows.Forms;

namespace ConsoleAppOne
{
   public partial class MyForm : Form
   {

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