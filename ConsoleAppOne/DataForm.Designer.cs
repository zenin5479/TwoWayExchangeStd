namespace ConsoleAppOne
{
   partial class DataForm
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
         greetingLabel = new System.Windows.Forms.Label();
         agreeCheckBox = new System.Windows.Forms.CheckBox();
         commentLabel = new System.Windows.Forms.Label();
         commentTextBox = new System.Windows.Forms.TextBox();
         closeButton = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // greetingLabel
         // 
         greetingLabel.AutoSize = true;
         greetingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         greetingLabel.Location = new System.Drawing.Point(12, 9);
         greetingLabel.Name = "greetingLabel";
         greetingLabel.Size = new System.Drawing.Size(65, 18);
         greetingLabel.TabIndex = 0;
         greetingLabel.Text = "";
         //greetingLabel.Text = string.Format("Привет, {0}!", _initialName);

         // 
         // agreeCheckBox
         // 
         agreeCheckBox.AutoSize = true;
         agreeCheckBox.Location = new System.Drawing.Point(12, 30);
         agreeCheckBox.Name = "agreeCheckBox";
         agreeCheckBox.Size = new System.Drawing.Size(159, 19);
         agreeCheckBox.TabIndex = 1;
         agreeCheckBox.Text = "Я согласен с условиями";
         agreeCheckBox.UseVisualStyleBackColor = true;
         // 
         // commentLabel
         // 
         commentLabel.AutoSize = true;
         commentLabel.Location = new System.Drawing.Point(12, 52);
         commentLabel.Name = "commentLabel";
         commentLabel.Size = new System.Drawing.Size(87, 15);
         commentLabel.TabIndex = 2;
         commentLabel.Text = "Комментарий:";
         // 
         // commentTextBox
         // 
         commentTextBox.Location = new System.Drawing.Point(12, 70);
         commentTextBox.Multiline = true;
         commentTextBox.Name = "commentTextBox";
         commentTextBox.Size = new System.Drawing.Size(200, 100);
         commentTextBox.TabIndex = 3;
         // 
         // closeButton
         // 
         closeButton.Location = new System.Drawing.Point(12, 176);
         closeButton.Name = "closeButton";
         closeButton.Size = new System.Drawing.Size(200, 23);
         closeButton.TabIndex = 4;
         closeButton.Text = "Закрыть и передать данные";
         closeButton.UseVisualStyleBackColor = true;
         closeButton.Click += closeButton_Click;
         // 
         // DataForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(225, 212);
         Controls.Add(closeButton);
         Controls.Add(commentTextBox);
         Controls.Add(commentLabel);
         Controls.Add(agreeCheckBox);
         Controls.Add(greetingLabel);
         Name = "DataForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Форма для передачи данных";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label greetingLabel;
      private System.Windows.Forms.CheckBox agreeCheckBox;
      private System.Windows.Forms.Label commentLabel;
      private System.Windows.Forms.TextBox commentTextBox;
      private System.Windows.Forms.Button closeButton;
   }
}