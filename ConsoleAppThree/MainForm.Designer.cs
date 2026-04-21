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
         inputBox = new System.Windows.Forms.TextBox();
         returnButton = new System.Windows.Forms.Button();
         messageLabel = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // inputBox
         // 
         inputBox.Location = new System.Drawing.Point(12, 64);
         inputBox.Multiline = true;
         inputBox.Name = "inputBox";
         inputBox.Size = new System.Drawing.Size(390, 50);
         inputBox.TabIndex = 5;
         // 
         // returnButton
         // 
         returnButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         returnButton.Location = new System.Drawing.Point(12, 142);
         returnButton.Name = "returnButton";
         returnButton.Size = new System.Drawing.Size(126, 23);
         returnButton.TabIndex = 4;
         returnButton.Text = "Вернуть в консоль";
         returnButton.UseVisualStyleBackColor = true;
         returnButton.Click += returnButton_Click;
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(12, 11);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(99, 15);
         messageLabel.TabIndex = 3;
         messageLabel.Text = "Обмен данными";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(414, 216);
         Controls.Add(inputBox);
         Controls.Add(returnButton);
         Controls.Add(messageLabel);
         Name = "MainForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Модальная форма с DialogResult";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox inputBox;
      private System.Windows.Forms.Button returnButton;
      private System.Windows.Forms.Label messageLabel;
   }
}