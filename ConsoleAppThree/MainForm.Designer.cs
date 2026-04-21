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
         messageLabel = new System.Windows.Forms.Label();
         cancelButton = new System.Windows.Forms.Button();
         inputBox = new System.Windows.Forms.TextBox();
         okButton = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(12, 9);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(99, 15);
         messageLabel.TabIndex = 0;
         messageLabel.Text = "Обмен данными";
         // 
         // cancelButton
         // 
         cancelButton.Location = new System.Drawing.Point(93, 83);
         cancelButton.Name = "cancelButton";
         cancelButton.Size = new System.Drawing.Size(126, 23);
         cancelButton.TabIndex = 1;
         cancelButton.Text = "Cancel";
         cancelButton.UseVisualStyleBackColor = true;
         cancelButton.Click += returnButton_Click;
         // 
         // inputBox
         // 
         inputBox.Location = new System.Drawing.Point(12, 27);
         inputBox.Multiline = true;
         inputBox.Name = "inputBox";
         inputBox.Size = new System.Drawing.Size(390, 50);
         inputBox.TabIndex = 2;
         // 
         // okButton
         // 
         okButton.Location = new System.Drawing.Point(12, 83);
         okButton.Name = "okButton";
         okButton.Size = new System.Drawing.Size(75, 23);
         okButton.TabIndex = 3;
         okButton.Text = "ОК";
         okButton.UseVisualStyleBackColor = true;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(414, 119);
         Controls.Add(okButton);
         Controls.Add(inputBox);
         Controls.Add(cancelButton);
         Controls.Add(messageLabel);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Обмен через ShowDialog() с DialogResult";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.TextBox inputBox;
      private System.Windows.Forms.Button okButton;
   }
}