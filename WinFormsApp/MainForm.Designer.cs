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
         btnReadCommand = new System.Windows.Forms.Button();
         rtbLog = new System.Windows.Forms.RichTextBox();
         SuspendLayout();
         // 
         // txtCommand
         // 
         txtCommand.Location = new System.Drawing.Point(12, 12);
         txtCommand.Multiline = true;
         txtCommand.Name = "txtCommand";
         txtCommand.Size = new System.Drawing.Size(404, 23);
         txtCommand.TabIndex = 0;
         // 
         // btnReadCommand
         // 
         btnReadCommand.Location = new System.Drawing.Point(12, 41);
         btnReadCommand.Name = "btnReadCommand";
         btnReadCommand.Size = new System.Drawing.Size(75, 23);
         btnReadCommand.TabIndex = 1;
         btnReadCommand.Text = "button1";
         btnReadCommand.UseVisualStyleBackColor = true;
         btnReadCommand.Click += btnSend_Click_1;
         // 
         // rtbLog
         // 
         rtbLog.Location = new System.Drawing.Point(12, 70);
         rtbLog.Name = "rtbLog";
         rtbLog.Size = new System.Drawing.Size(404, 119);
         rtbLog.TabIndex = 2;
         rtbLog.Text = "";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(428, 201);
         Controls.Add(rtbLog);
         Controls.Add(btnReadCommand);
         Controls.Add(txtCommand);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Двусторонний обмен WinForms и консоли";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtCommand;
      private System.Windows.Forms.Button btnReadCommand;
      private System.Windows.Forms.RichTextBox rtbLog;
   }
}
