using System;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         // Запускаем цикл обмена ПОСЛЕ того, как форма показана
         Shown += MainForm_Shown;
      }

      private void MainForm_Shown(object sender, EventArgs e)
      {
         // Основной цикл обмена – блокирует UI поток, но это разрешено
         while (true)
         {
            // 1. Синхронно читаем запрос из stdin (блокирует форму)
            string request = Console.ReadLine();
            if (request == null)
            {
               break; // консоль закрыла поток
            }

            if (request.ToLower() == "exit")
            {
               break;
            }

            // 2. Показываем запрос в форме (форма всё ещё не реагирует на клики,
            //    но текст обновится)
            lblStatus.Text = $"Получен запрос: {request}";
            txtLastRequest.Text = request;
            Refresh(); // принудительная перерисовка

            // 3. Показываем модальное диалоговое окно для ввода ответа
            //    Оно блокирует выполнение кода, но не требует DoEvents.
            string response = ShowInputDialog(request);
            if (response == null) response = "";

            // 4. Отправляем ответ обратно в консоль
            Console.WriteLine(response);
            lblStatus.Text = "Ожидание следующего запроса...";
         }

         // По завершении цикла закрываем приложение
         Application.Exit();
      }

      private string ShowInputDialog(string request)
      {
         // Простой модальный диалог через форму
         using (var dialog = new Form())
         {
            dialog.Text = "Введите ответ";
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.Size = new System.Drawing.Size(300, 120);

            var label = new Label() { Text = request, Location = new System.Drawing.Point(10, 10), AutoSize = true };
            var textBox = new TextBox() { Location = new System.Drawing.Point(10, 35), Size = new System.Drawing.Size(260, 23) };
            var buttonOk = new Button() { Text = "OK", Location = new System.Drawing.Point(120, 65), DialogResult = DialogResult.OK };
            var buttonCancel = new Button() { Text = "Отмена", Location = new System.Drawing.Point(200, 65), DialogResult = DialogResult.Cancel };

            dialog.Controls.Add(label);
            dialog.Controls.Add(textBox);
            dialog.Controls.Add(buttonOk);
            dialog.Controls.Add(buttonCancel);
            dialog.AcceptButton = buttonOk;
            dialog.CancelButton = buttonCancel;

            if (dialog.ShowDialog() == DialogResult.OK)
               return textBox.Text;
            else
               return null;
         }
      }
   }
}