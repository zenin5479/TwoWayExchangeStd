using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsoleAppTwo
{
   public partial class DataForm : Form
   {
      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }


      public DataForm(string initialName)
      {
         InitializeComponent();

         greetingLabel.Text = string.Format("Привет, {0}!", initialName);
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         // Перед закрытием сохраняем данные в свойства
         UserAgreed = agreeCheckBox.Checked;
         UserComment = commentTextBox.Text;
         Close();
      }
   }
}