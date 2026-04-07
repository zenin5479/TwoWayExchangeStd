using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         // Запускаем цикл обмена ПОСЛЕ того, как форма показана
         this.Shown += MainForm_Shown;
      }
   }
}