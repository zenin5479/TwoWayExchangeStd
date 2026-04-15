namespace ConsoleAppFour
{
   partial class FormConstructor
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
         inputBox = new System.Windows.Forms.TextBox();
         returnButton = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(53, 42);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(38, 15);
         messageLabel.TabIndex = 0;
         messageLabel.Text = "label1";
         // 
         // inputBox
         // 
         inputBox.Location = new System.Drawing.Point(63, 100);
         inputBox.Multiline = true;
         inputBox.Name = "inputBox";
         inputBox.Size = new System.Drawing.Size(100, 23);
         inputBox.TabIndex = 1;
         // 
         // returnButton
         // 
         returnButton.Location = new System.Drawing.Point(158, 129);
         returnButton.Name = "returnButton";
         returnButton.Size = new System.Drawing.Size(150, 120);
         returnButton.TabIndex = 2;
         returnButton.Text = "Вернуть в консоль";
         returnButton.UseVisualStyleBackColor = true;
         // 
         // FormConstructor
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(returnButton);
         Controls.Add(inputBox);
         Controls.Add(messageLabel);
         Name = "FormConstructor";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Обмен данными";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.TextBox inputBox;
      private System.Windows.Forms.Button returnButton;
   }
}