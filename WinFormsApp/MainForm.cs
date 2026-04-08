using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         this.Text = "Windows Forms приложение (запущено консолью)";

         // Показываем информацию о родительском процессе
         var parentProcess = GetParentProcess();
         if (parentProcess != null)
         {
            lblParent.Text = $"Родительский процесс: {parentProcess.ProcessName} (PID: {parentProcess.Id})";
         }
      }
   }
}