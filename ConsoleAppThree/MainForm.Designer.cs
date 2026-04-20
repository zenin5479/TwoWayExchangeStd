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
         returnButton = new System.Windows.Forms.Button();
         inputBox = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(48, 21);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(38, 15);
         messageLabel.TabIndex = 0;
         messageLabel.Text = "label1";
         // 
         // returnButton
         // 
         returnButton.Location = new System.Drawing.Point(101, 47);
         returnButton.Name = "returnButton";
         returnButton.Size = new System.Drawing.Size(75, 23);
         returnButton.TabIndex = 1;
         returnButton.Text = "button1";
         returnButton.UseVisualStyleBackColor = true;
         returnButton.Click += returnButton_Click;
         // 
         // inputBox
         // 
         inputBox.Location = new System.Drawing.Point(48, 76);
         inputBox.Multiline = true;
         inputBox.Name = "inputBox";
         inputBox.Size = new System.Drawing.Size(189, 120);
         inputBox.TabIndex = 2;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(293, 241);
         Controls.Add(inputBox);
         Controls.Add(returnButton);
         Controls.Add(messageLabel);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Моя Windows Forms";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Button returnButton;
      private System.Windows.Forms.TextBox inputBox;
   }
}