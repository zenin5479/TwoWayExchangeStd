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
         lblStatus = new System.Windows.Forms.Label();
         txtLastRequest = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // lblStatus
         // 
         lblStatus.AutoSize = true;
         lblStatus.Location = new System.Drawing.Point(12, 9);
         lblStatus.Name = "lblStatus";
         lblStatus.Size = new System.Drawing.Size(120, 15);
         lblStatus.TabIndex = 0;
         lblStatus.Text = "Ожидание запроса...";
         // 
         // txtLastRequest
         // 
         txtLastRequest.Location = new System.Drawing.Point(12, 27);
         txtLastRequest.Multiline = true;
         txtLastRequest.Name = "txtLastRequest";
         txtLastRequest.Size = new System.Drawing.Size(210, 130);
         txtLastRequest.TabIndex = 1;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(237, 173);
         Controls.Add(txtLastRequest);
         Controls.Add(lblStatus);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Двусторонний обмен WinForms и консоли";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.TextBox txtLastRequest;
   }
}
