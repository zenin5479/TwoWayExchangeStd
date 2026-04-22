namespace ConsoleAppSix
{
   partial class FormStorage
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
         textBox1 = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // textBox1
         // 
         textBox1.Location = new System.Drawing.Point(12, 12);
         textBox1.Multiline = true;
         textBox1.Name = "textBox1";
         textBox1.Size = new System.Drawing.Size(178, 54);
         textBox1.TabIndex = 0;
         // 
         // FormStorage
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(textBox1);
         Name = "FormStorage";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "FormStorage";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
   }
}