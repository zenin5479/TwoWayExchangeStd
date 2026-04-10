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
         SuspendLayout();
         // 
         // greetingLabel
         // 
         greetingLabel.AutoSize = true;
         greetingLabel.Location = new System.Drawing.Point(51, 21);
         greetingLabel.Name = "greetingLabel";
         greetingLabel.Size = new System.Drawing.Size(50, 15);
         greetingLabel.TabIndex = 0;
         greetingLabel.Text = "Привет!";
         // 
         // DataForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(384, 211);
         Controls.Add(greetingLabel);
         Name = "DataForm";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Форма для передачи данных";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label greetingLabel;
   }
}