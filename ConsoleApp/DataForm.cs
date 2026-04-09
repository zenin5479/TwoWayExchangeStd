using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp
{
   // Простая форма с элементами ввода
   public class DataForm : Form
   {
      private CheckBox agreeCheckBox;
      private TextBox commentTextBox;
      private Button closeButton;

      // Свойства для чтения результатов после закрытия
      public bool UserAgreed { get; private set; }
      public string UserComment { get; private set; }

      public DataForm(string initialName)
      {
         Text = "Форма для передачи данных";
         Width = 400;
         Height = 250;
         StartPosition = FormStartPosition.CenterScreen;

         // Приветствие с переданным из консоли именем
         Label greetingLabel = new Label
         {
            Text = string.Format("Привет, {0}!", initialName),
            Location = new Point(20, 20),
            AutoSize = true,
            Font = new Font("Arial", 12, FontStyle.Bold)
         };

         // Чекбокс для выбора
         agreeCheckBox = new CheckBox
         {
            Text = "Я согласен с условиями",
            Location = new Point(20, 60),
            AutoSize = true
         };

         // Поле для комментария
         Label commentLabel = new Label
         {
            Text = "Комментарий:",
            Location = new Point(20, 90),
            AutoSize = true
         };

         commentTextBox = new TextBox
         {
            Location = new Point(20, 110),
            Width = 300
         };

         // Кнопка закрытия
         closeButton = new Button
         {
            Text = "Закрыть и передать данные",
            Location = new Point(20, 150),
            Width = 200
         };

         closeButton.Click += (sender, e) =>
         {
            // Перед закрытием сохраняем данные в свойства
            UserAgreed = agreeCheckBox.Checked;
            UserComment = commentTextBox.Text;
            Close();
         };

         // Добавляем элементы на форму
         Controls.AddRange(new Control[] 
         {
                greetingLabel,
                agreeCheckBox,
                commentLabel,
                commentTextBox,
                closeButton
         });
      }
   }
}