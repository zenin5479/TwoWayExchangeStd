using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         Text = "Windows Forms from Console";
         Label label = new Label { Text = "Form opened by console app", AutoSize = true };
         Controls.Add(label);
      }
   }
}