using System;
using System.Windows.Forms;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         // --- Часть 1: Консоль передаёт данные в форму ---
         Console.Write("Введите ваше имя: ");
         string userName = Console.ReadLine();

         // Создаём форму, передавая начальные данные через конструктор
         DataForm myForm = new DataForm(userName);

         // Включаем визуальные стили (опционально)
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // --- Часть 2: Показываем форму (консоль ждёт) ---
         Console.WriteLine("Открываем форму... Введите данные в окне и закройте его.");
         Application.Run(myForm); // Здесь выполнение консоли останавливается

         // --- Часть 3: Форма закрыта, читаем результаты ---
         // Получаем данные из публичных свойств формы
         bool userChoice = myForm.UserAgreed;
         string userComment = myForm.UserComment;

         Console.WriteLine("\nФорма закрыта. Получены данные:");
         Console.WriteLine($"Пользователь согласился: {userChoice}");
         Console.WriteLine($"Комментарий: {userComment}");

         Console.WriteLine("\nНажмите любую клавишу для выхода...");
         Console.ReadKey();
      }

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
            this.Text = "Форма для передачи данных";
            this.Width = 400;
            this.Height = 250;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Приветствие с переданным из консоли именем
            Label greetingLabel = new Label
            {
               Text = $"Привет, {initialName}!",
               Location = new System.Drawing.Point(20, 20),
               AutoSize = true,
               Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
            };

            // Чекбокс для выбора
            agreeCheckBox = new CheckBox
            {
               Text = "Я согласен с условиями",
               Location = new System.Drawing.Point(20, 60),
               AutoSize = true
            };

            // Поле для комментария
            Label commentLabel = new Label
            {
               Text = "Комментарий:",
               Location = new System.Drawing.Point(20, 90),
               AutoSize = true
            };

            commentTextBox = new TextBox
            {
               Location = new System.Drawing.Point(20, 110),
               Width = 300
            };

            // Кнопка закрытия
            closeButton = new Button
            {
               Text = "Закрыть и передать данные",
               Location = new System.Drawing.Point(20, 150),
               Width = 200
            };

            closeButton.Click += (sender, e) =>
            {
               // Перед закрытием сохраняем данные в свойства
               UserAgreed = agreeCheckBox.Checked;
               UserComment = commentTextBox.Text;
               this.Close();
            };

            // Добавляем элементы на форму
            this.Controls.AddRange(new Control[] {
                greetingLabel,
                agreeCheckBox,
                commentLabel,
                commentTextBox,
                closeButton
            });
         }
      }
   }
}