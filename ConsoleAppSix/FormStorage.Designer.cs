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
         ageBox = new System.Windows.Forms.NumericUpDown();
         button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)ageBox).BeginInit();
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
         // ageBox
         // 
         ageBox.Location = new System.Drawing.Point(12, 72);
         ageBox.Name = "ageBox";
         ageBox.Size = new System.Drawing.Size(178, 23);
         ageBox.TabIndex = 1;
         // 
         // button1
         // 
         button1.Location = new System.Drawing.Point(12, 101);
         button1.Name = "button1";
         button1.Size = new System.Drawing.Size(75, 23);
         button1.TabIndex = 2;
         button1.Text = "button1";
         button1.UseVisualStyleBackColor = true;
         // 
         // FormStorage
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 261);
         Controls.Add(button1);
         Controls.Add(ageBox);
         Controls.Add(nameBox);
         Name = "FormStorage";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "FormStorage";
         ((System.ComponentModel.ISupportInitialize)ageBox).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox nameBox;
      private System.Windows.Forms.NumericUpDown ageBox;
      private System.Windows.Forms.Button button1;
   }
}