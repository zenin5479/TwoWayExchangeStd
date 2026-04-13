namespace ConsoleAppThree
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         helloButton = new System.Windows.Forms.Button();
         messageLabel = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // helloButton
         // 
         helloButton.Location = new System.Drawing.Point(12, 27);
         helloButton.Name = "helloButton";
         helloButton.Size = new System.Drawing.Size(155, 23);
         helloButton.TabIndex = 0;
         helloButton.Text = "Нажми меня!";
         helloButton.UseVisualStyleBackColor = true;
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(12, 9);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(132, 15);
         messageLabel.TabIndex = 1;
         messageLabel.Text = "Нажмите кнопку ниже";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(messageLabel);
         Controls.Add(helloButton);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "MainForm";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button helloButton;
      private System.Windows.Forms.Label messageLabel;
   }
}