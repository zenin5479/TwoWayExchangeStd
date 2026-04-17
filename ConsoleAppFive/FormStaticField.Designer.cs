namespace ConsoleAppFive
{
   partial class FormStaticField
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
         messageLabel.Location = new System.Drawing.Point(12, 9);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(180, 15);
         messageLabel.TabIndex = 1;
         messageLabel.Text = "Получение данных из консоли:";
         // 
         // returnButton
         // 
         returnButton.Location = new System.Drawing.Point(12, 164);
         returnButton.Name = "returnButton";
         returnButton.Size = new System.Drawing.Size(180, 30);
         returnButton.TabIndex = 2;
         returnButton.Text = "Вернуть в консоль данные";
         returnButton.UseVisualStyleBackColor = true;
         returnButton.Click += returnButton_Click;
         // 
         // inputBox
         // 
         inputBox.Location = new System.Drawing.Point(12, 27);
         inputBox.Multiline = true;
         inputBox.Name = "inputBox";
         inputBox.Size = new System.Drawing.Size(180, 111);
         inputBox.TabIndex = 3;
         // 
         // FormStaticField
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(442, 206);
         Controls.Add(inputBox);
         Controls.Add(returnButton);
         Controls.Add(messageLabel);
         Name = "FormStaticField";
         Text = "Двусторонний обмен через статическое поле";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Button returnButton;
      private System.Windows.Forms.TextBox inputBox;
   }
}