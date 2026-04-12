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
         SuspendLayout();
         // 
         // closeButton
         // 
         closeButton.Location = new System.Drawing.Point(12, 146);
         closeButton.Name = "closeButton";
         closeButton.Size = new System.Drawing.Size(174, 23);
         closeButton.TabIndex = 4;
         closeButton.Text = "Закрыть";
         closeButton.UseVisualStyleBackColor = true;
         closeButton.Click += closeButton_Click;
         // 
         // MyForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(339, 181);
         Controls.Add(closeButton);
         Name = "MyForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Моя форма из консоли";
         ResumeLayout(false);
      }

      #endregion
      private System.Windows.Forms.Button closeButton;
   }
}