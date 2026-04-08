using System.Windows.Forms;
using System;

namespace WinFormsApp
{
   partial class MainForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         SuspendLayout();
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(389, 173);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Двусторонний обмен WinForms и консоли";
         ResumeLayout(false);

         this.lblStatus = new Label();

         // lblStatus
         this.lblStatus.Location = new System.Drawing.Point(12, 12);
         this.lblStatus.Size = new System.Drawing.Size(350, 20);
         this.lblStatus.Text = "Инициализация...";

         // Form1
         this.ClientSize = new System.Drawing.Size(400, 100);
         this.Controls.Add(this.lblStatus);
         this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);

      }

      #endregion
   }
}