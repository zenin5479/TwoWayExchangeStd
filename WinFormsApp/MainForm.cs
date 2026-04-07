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

            // 2. Показываем запрос в форме (форма всё ещё не реагирует на клики, но текст обновится)
            lblStatus.Text = string.Format("Получен запрос: {0}", request);
            txtLastRequest.Text = request;
            Refresh(); // принудительная перерисовка

            // 3. Показываем модальное диалоговое окно для ввода ответа оно блокирует выполнение кода
            string response = ShowInputDialog(request);
            if (response == null)
            {
               response = "";
            }

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
         using (MainForm dialog = new MainForm())
         {

            Label label = new Label() { Text = request, Location = new System.Drawing.Point(10, 10), AutoSize = true };


            dialog.Controls.Add(label);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
               return txtLastRequest.Text;
            }

            return null;
         }
      }
   }
}