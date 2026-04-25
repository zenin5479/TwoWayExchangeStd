namespace ConsoleAppSeven
{
   partial class DataEditorForm
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
         dataListBox = new System.Windows.Forms.ListBox();
         nameTextBox = new System.Windows.Forms.TextBox();
         ageTextBox = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // dataListBox
         // 
         dataListBox.FormattingEnabled = true;
         dataListBox.ItemHeight = 15;
         dataListBox.Location = new System.Drawing.Point(12, 12);
         dataListBox.Name = "dataListBox";
         dataListBox.Size = new System.Drawing.Size(300, 199);
         dataListBox.TabIndex = 0;
         // 
         // nameTextBox
         // 
         nameTextBox.Location = new System.Drawing.Point(12, 217);
         nameTextBox.Name = "nameTextBox";
         nameTextBox.Size = new System.Drawing.Size(150, 23);
         nameTextBox.TabIndex = 1;
         // 
         // ageTextBox
         // 
         ageTextBox.Location = new System.Drawing.Point(12, 246);
         ageTextBox.Name = "ageTextBox";
         ageTextBox.Size = new System.Drawing.Size(150, 23);
         ageTextBox.TabIndex = 2;
         // 
         // DataEditorForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(484, 361);
         Controls.Add(ageTextBox);
         Controls.Add(nameTextBox);
         Controls.Add(dataListBox);
         Name = "DataEditorForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Редактор данных";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.ListBox dataListBox;
      private System.Windows.Forms.TextBox nameTextBox;
      private System.Windows.Forms.TextBox ageTextBox;
   }
}