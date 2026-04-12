namespace ConsoleAppTwo
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
         closeButton = new System.Windows.Forms.Button();
         commentTextBox = new System.Windows.Forms.TextBox();
         commentLabel = new System.Windows.Forms.Label();
         agreeCheckBox = new System.Windows.Forms.CheckBox();
         SuspendLayout();
         // 
         // greetingLabel
         // 
         greetingLabel.AutoSize = true;
         greetingLabel.Location = new System.Drawing.Point(12, 9);
         greetingLabel.Name = "greetingLabel";
         greetingLabel.Size = new System.Drawing.Size(115, 15);
         greetingLabel.TabIndex = 10;
         greetingLabel.Text = "Данные из консоли";
         // 
         // closeButton
         // 
         closeButton.Location = new System.Drawing.Point(12, 146);
         closeButton.Name = "closeButton";
         closeButton.Size = new System.Drawing.Size(174, 23);
         closeButton.TabIndex = 9;
         closeButton.Text = "Закрыть и передать данные";
         closeButton.UseVisualStyleBackColor = true;
         closeButton.Click += closeButton_Click;
         // 
         // commentTextBox
         // 
         commentTextBox.Location = new System.Drawing.Point(12, 67);
         commentTextBox.Multiline = true;
         commentTextBox.Name = "commentTextBox";
         commentTextBox.Size = new System.Drawing.Size(315, 73);
         commentTextBox.TabIndex = 8;
         // 
         // commentLabel
         // 
         commentLabel.AutoSize = true;
         commentLabel.Location = new System.Drawing.Point(12, 49);
         commentLabel.Name = "commentLabel";
         commentLabel.Size = new System.Drawing.Size(87, 15);
         commentLabel.TabIndex = 7;
         commentLabel.Text = "Комментарий:";
         // 
         // agreeCheckBox
         // 
         agreeCheckBox.AutoSize = true;
         agreeCheckBox.Location = new System.Drawing.Point(12, 27);
         agreeCheckBox.Name = "agreeCheckBox";
         agreeCheckBox.Size = new System.Drawing.Size(159, 19);
         agreeCheckBox.TabIndex = 6;
         agreeCheckBox.Text = "Я согласен с условиями";
         agreeCheckBox.UseVisualStyleBackColor = true;
         // 
         // DataForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(339, 181);
         Controls.Add(greetingLabel);
         Controls.Add(closeButton);
         Controls.Add(commentTextBox);
         Controls.Add(commentLabel);
         Controls.Add(agreeCheckBox);
         Name = "DataForm";
         Text = "Форма для передачи данных";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label greetingLabel;
      private System.Windows.Forms.Button closeButton;
      private System.Windows.Forms.TextBox commentTextBox;
      private System.Windows.Forms.Label commentLabel;
      private System.Windows.Forms.CheckBox agreeCheckBox;
   }
}