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
         greetingLabel.Text = "Привет!";
         // 
         // agreeCheckBox
         // 
         agreeCheckBox.AutoSize = true;
         agreeCheckBox.Location = new System.Drawing.Point(12, 56);
         agreeCheckBox.Name = "agreeCheckBox";
         agreeCheckBox.Size = new System.Drawing.Size(159, 19);
         agreeCheckBox.TabIndex = 1;
         agreeCheckBox.Text = "Я согласен с условиями";
         agreeCheckBox.UseVisualStyleBackColor = true;
         // 
         // commentLabel
         // 
         commentLabel.AutoSize = true;
         commentLabel.Location = new System.Drawing.Point(54, 100);
         commentLabel.Name = "commentLabel";
         commentLabel.Size = new System.Drawing.Size(38, 15);
         commentLabel.TabIndex = 2;
         commentLabel.Text = "label1";
         // 
         // DataForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 211);
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
   }
}