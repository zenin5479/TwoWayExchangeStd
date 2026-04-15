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
         SuspendLayout();
         // 
         // messageLabel
         // 
         messageLabel.AutoSize = true;
         messageLabel.Location = new System.Drawing.Point(12, 9);
         messageLabel.Name = "messageLabel";
         messageLabel.Size = new System.Drawing.Size(177, 15);
         messageLabel.TabIndex = 0;
         messageLabel.Text = "Получение данных из консоли";
         // 
         // FormConstructor
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(377, 43);
         Controls.Add(messageLabel);
         Name = "FormConstructor";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Передача данных через конструктор";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label messageLabel;
   }
}