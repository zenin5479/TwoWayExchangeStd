using System;
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

      private void InitializeComponent()
      {
         this.lblParent = new Label();
         this.btnClose = new Button();

         // lblParent
         this.lblParent.Location = new System.Drawing.Point(12, 12);
         this.lblParent.Size = new System.Drawing.Size(350, 20);
         this.lblParent.Text = "Родительский процесс не определён";

         // btnClose
         this.btnClose.Location = new System.Drawing.Point(12, 40);
         this.btnClose.Size = new System.Drawing.Size(100, 30);
         this.btnClose.Text = "Закрыть";
         this.btnClose.Click += new EventHandler(this.btnClose_Click);

         // Form1
         this.ClientSize = new System.Drawing.Size(400, 80);
         this.Controls.Add(this.lblParent);
         this.Controls.Add(this.btnClose);
         this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
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