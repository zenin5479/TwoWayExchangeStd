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
         nameBox = new System.Windows.Forms.TextBox();
         numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
         SuspendLayout();
         // 
         // nameBox
         // 
         nameBox.Location = new System.Drawing.Point(12, 12);
         nameBox.Multiline = true;
         nameBox.Name = "nameBox";
         nameBox.Size = new System.Drawing.Size(178, 54);
         nameBox.TabIndex = 0;
         // 
         // numericUpDown1
         // 
         numericUpDown1.Location = new System.Drawing.Point(12, 72);
         numericUpDown1.Name = "numericUpDown1";
         numericUpDown1.Size = new System.Drawing.Size(120, 23);
         numericUpDown1.TabIndex = 1;
         // 
         // FormStorage
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(numericUpDown1);
         Controls.Add(nameBox);
         Name = "FormStorage";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "FormStorage";
         ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox nameBox;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
   }
}