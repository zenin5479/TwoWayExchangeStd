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
         txtCommand = new System.Windows.Forms.TextBox();
         btnSend = new System.Windows.Forms.Button();
         rtbLog = new System.Windows.Forms.RichTextBox();
         SuspendLayout();
         // 
         // txtCommand
         // 
         txtCommand.Location = new System.Drawing.Point(63, 38);
         txtCommand.Name = "txtCommand";
         txtCommand.Size = new System.Drawing.Size(100, 23);
         txtCommand.TabIndex = 0;
         // 
         // btnSend
         // 
         btnSend.Location = new System.Drawing.Point(71, 108);
         btnSend.Name = "btnSend";
         btnSend.Size = new System.Drawing.Size(75, 23);
         btnSend.TabIndex = 1;
         btnSend.Text = "button1";
         btnSend.UseVisualStyleBackColor = true;
         // 
         // rtbLog
         // 
         rtbLog.Location = new System.Drawing.Point(63, 153);
         rtbLog.Name = "rtbLog";
         rtbLog.Size = new System.Drawing.Size(100, 96);
         rtbLog.TabIndex = 2;
         rtbLog.Text = "";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(rtbLog);
         Controls.Add(btnSend);
         Controls.Add(txtCommand);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Двусторонний обмен WinForms и консоли";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtCommand;
      private System.Windows.Forms.Button btnSend;
      private System.Windows.Forms.RichTextBox rtbLog;
   }
}
