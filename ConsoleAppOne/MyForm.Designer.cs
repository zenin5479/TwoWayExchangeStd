namespace ConsoleAppOne
{
   partial class MyForm
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
         closeButton = new System.Windows.Forms.Button();
         messageLabel = new System.Windows.Forms.Label();
         helloButton = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // closeButton
         // 
         closeButton.Location = new System.Drawing.Point(21, 99);
         closeButton.Name = "closeButton";
         closeButton.Size = new System.Drawing.Size(300, 45);
         closeButton.TabIndex = 4;
         closeButton.Text = "Закрыть форму";
         closeButton.UseVisualStyleBackColor = true;
         closeButton.Click += closeButton_Click;
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(12, 9);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(132, 15);
         messageLabel.TabIndex = 6;
         messageLabel.Text = "Нажмите кнопку ниже";
         // 
         // helloButton
         // 
         helloButton.Location = new System.Drawing.Point(21, 220);
         helloButton.Name = "helloButton";
         helloButton.Size = new System.Drawing.Size(260, 50);
         helloButton.TabIndex = 5;
         helloButton.Text = "Нажми меня!";
         helloButton.UseVisualStyleBackColor = true;
         helloButton.Click += helloButton_Click;
         // 
         // MyForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(324, 313);
         Controls.Add(messageLabel);
         Controls.Add(helloButton);
         Controls.Add(closeButton);
         Name = "MyForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Моя форма из консоли";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private System.Windows.Forms.Button closeButton;
      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Button helloButton;
   }
}