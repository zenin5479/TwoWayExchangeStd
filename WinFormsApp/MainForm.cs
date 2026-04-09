using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      private Process childProcess;
      private StreamWriter childInput;
      private StreamReader childOutput;

      public MainForm()
      {
         InitializeComponent();
      }
   }
}