using System;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         Load += MainForm_Load;
         FormClosing += Form1_FormClosing;
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         // Выводим окно на передний план
         TopMost = true;
         Activate();
         BringToFront();

         Log("Form loaded. Waiting for commands from console...");

         // Синхронный цикл обработки stdin (БЛОКИРУЕТ UI)
         while (true)
         {
            string command = Console.ReadLine();
            if (command == null)
            {
               break; // родитель закрыл stdin
            }

            Log($">> Received: {command}");

            string response;
            if (command.ToUpperInvariant() == "PING")
            {
               response = "PONG";
            }
            else if (command.ToUpperInvariant() == "TIME")
            {
               response = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (command.ToUpperInvariant() == "EXIT")
            {
               response = "BYE";
            }
            else
            {
               response = $"UNKNOWN: {command}";
            }

            Console.WriteLine(response);
            Log($"<< Sent: {response}");

            if (command.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
            {
               Close();
               break;
            }
         }
      }

      private void Log(string message)
      {
         // Вывод в RichTextBox (если он есть) или в заголовок окна
         if (rtbLog != null)
         {
            rtbLog.AppendText($"{message}{Environment.NewLine}");
         }
         else
         {
            Text = message;
         }
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         Log("Form closing...");
      }
   }
}