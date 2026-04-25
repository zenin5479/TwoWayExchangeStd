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
         emailTextBox = new System.Windows.Forms.TextBox();
         addButton = new System.Windows.Forms.Button();
         saveButton = new System.Windows.Forms.Button();
         deleteButton = new System.Windows.Forms.Button();
         selectedIndexLabel = new System.Windows.Forms.Label();
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
         nameTextBox.Location = new System.Drawing.Point(322, 12);
         nameTextBox.Name = "nameTextBox";
         nameTextBox.Size = new System.Drawing.Size(150, 23);
         nameTextBox.TabIndex = 1;
         // 
         // ageTextBox
         // 
         ageTextBox.Location = new System.Drawing.Point(322, 41);
         ageTextBox.Name = "ageTextBox";
         ageTextBox.Size = new System.Drawing.Size(150, 23);
         ageTextBox.TabIndex = 2;
         // 
         // emailTextBox
         // 
         emailTextBox.Location = new System.Drawing.Point(322, 70);
         emailTextBox.Name = "emailTextBox";
         emailTextBox.Size = new System.Drawing.Size(150, 23);
         emailTextBox.TabIndex = 3;
         // 
         // addButton
         // 
         addButton.Location = new System.Drawing.Point(12, 217);
         addButton.Name = "addButton";
         addButton.Size = new System.Drawing.Size(75, 23);
         addButton.TabIndex = 4;
         addButton.Text = "Добавить";
         addButton.UseVisualStyleBackColor = true;
         // 
         // saveButton
         // 
         saveButton.Location = new System.Drawing.Point(93, 217);
         saveButton.Name = "saveButton";
         saveButton.Size = new System.Drawing.Size(75, 23);
         saveButton.TabIndex = 5;
         saveButton.Text = "Сохранить";
         saveButton.UseVisualStyleBackColor = true;
         // 
         // deleteButton
         // 
         deleteButton.Location = new System.Drawing.Point(174, 217);
         deleteButton.Name = "deleteButton";
         deleteButton.Size = new System.Drawing.Size(75, 23);
         deleteButton.TabIndex = 6;
         deleteButton.Text = "Удалить";
         deleteButton.UseVisualStyleBackColor = true;
         // 
         // selectedIndexLabel
         // 
         selectedIndexLabel.AutoSize = true;
         selectedIndexLabel.Location = new System.Drawing.Point(41, 278);
         selectedIndexLabel.Name = "selectedIndexLabel";
         selectedIndexLabel.Size = new System.Drawing.Size(38, 15);
         selectedIndexLabel.TabIndex = 7;
         selectedIndexLabel.Text = "label1";
         // 
         // DataEditorForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(484, 361);
         Controls.Add(selectedIndexLabel);
         Controls.Add(deleteButton);
         Controls.Add(saveButton);
         Controls.Add(addButton);
         Controls.Add(emailTextBox);
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
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button deleteButton;
      private System.Windows.Forms.Label selectedIndexLabel;
   }
}