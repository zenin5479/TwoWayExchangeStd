using System;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
         FormClosing += Form1_FormClosing;
         Log("Windows Forms started. Waiting for commands on stdin...");
      }

      // Синхронное чтение команды из stdin (блокирует UI)
      private void btnReadCommand_Click(object sender, EventArgs e)
      {
         Log("Waiting for command from console...");

         // ReadLine блокирует поток до появления строки в stdin
         string command = Console.ReadLine();

         if (command == null)
         {
            Log("stdin closed (EOF). Parent process terminated.");
            btnReadCommand.Enabled = false;
            return;
         }

         Log($">> Received: {command}");

         // Обработка команды
         string response = command.ToUpperInvariant() switch
         {
            "PING" => "PONG",
            "TIME" => DateTime.Now.ToString("HH:mm:ss"),
            "EXIT" => "BYE",
            _ => $"UNKNOWN: {command}"
         };

         // Отправляем ответ в stdout
         Console.WriteLine(response);
         Log($"<< Sent: {response}");

         if (command.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
         {
            Log("Exit command received. Closing form...");
            Close();
         }
      }

      private void Log(string message)
      {
         // Вывод в RichTextBox (вызов из любого потока не требуется, всё в UI)
         rtbLog.AppendText($"{message}{Environment.NewLine}");
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         Log("Form closing...");
      }
   }
}