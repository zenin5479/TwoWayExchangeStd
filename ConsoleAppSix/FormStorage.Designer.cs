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
         saveButton = new System.Windows.Forms.Button();
         showDataButton = new System.Windows.Forms.Button();
         displayLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)ageBox).BeginInit();
         SuspendLayout();
         // 
         // nameBox
         // 
         nameBox.Location = new System.Drawing.Point(12, 12);
         nameBox.Multiline = true;
         nameBox.Name = "nameBox";
         nameBox.Size = new System.Drawing.Size(340, 54);
         nameBox.TabIndex = 0;
         // 
         // ageBox
         // 
         ageBox.Location = new System.Drawing.Point(12, 72);
         ageBox.Name = "ageBox";
         ageBox.Size = new System.Drawing.Size(178, 23);
         ageBox.TabIndex = 1;
         // 
         // saveButton
         // 
         saveButton.Location = new System.Drawing.Point(12, 101);
         saveButton.Name = "saveButton";
         saveButton.Size = new System.Drawing.Size(178, 23);
         saveButton.TabIndex = 2;
         saveButton.Text = "Сохранить в хранилище";
         saveButton.UseVisualStyleBackColor = true;
         saveButton.Click += saveButton_Click;
         // 
         // showDataButton
         // 
         showDataButton.Location = new System.Drawing.Point(12, 130);
         showDataButton.Name = "showDataButton";
         showDataButton.Size = new System.Drawing.Size(178, 23);
         showDataButton.TabIndex = 3;
         showDataButton.Text = "Показать все данные";
         showDataButton.UseVisualStyleBackColor = true;
         showDataButton.Click += showDataButton_Click;
         // 
         // displayLabel
         // 
         displayLabel.AutoSize = true;
         displayLabel.Location = new System.Drawing.Point(196, 74);
         displayLabel.Name = "displayLabel";
         displayLabel.Size = new System.Drawing.Size(50, 15);
         displayLabel.TabIndex = 4;
         displayLabel.Text = "Данные";
         // 
         // FormStorage
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(476, 165);
         Controls.Add(displayLabel);
         Controls.Add(showDataButton);
         Controls.Add(saveButton);
         Controls.Add(ageBox);
         Controls.Add(nameBox);
         Name = "FormStorage";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Форма с глобальным хранилищем";
         ((System.ComponentModel.ISupportInitialize)ageBox).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox nameBox;
      private System.Windows.Forms.NumericUpDown ageBox;
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button showDataButton;
      private System.Windows.Forms.Label displayLabel;
   }
}