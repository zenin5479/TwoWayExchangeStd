using System;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      private Label lblParent;
      private Button btnClose;

      public MainForm()
      {
         InitializeComponent();
         this.Text = "Windows Forms приложение (запущено консолью)";
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         DialogResult result = MessageBox.Show(
            ("Вы уверены, что хотите закрыть приложение?\n" +
             "Это также уведомит консольное приложение о завершении."),
            "Подтверждение закрытия",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
         if (result == DialogResult.No)
         {
            e.Cancel = true;
         }
      }
   }
}