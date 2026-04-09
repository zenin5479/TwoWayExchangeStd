using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      private Process childProcess;
      private StreamWriter childInput;
      private StreamReader childOutput;

      public MainForm()
      {
         InitializeComponent();
         FormClosing += MainForm_FormClosing;
         StartChildProcess();
      }

      private void StartChildProcess()
      {
         var startInfo = new ProcessStartInfo
         {
            FileName = "ConsoleApp.exe",      // путь к консольному приложению
            UseShellExecute = false,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
         };

         childProcess = new Process { StartInfo = startInfo };
         childProcess.Start();

         // Получаем потоки
         childInput = childProcess.StandardInput;
         childOutput = childProcess.StandardOutput;

         // Читаем приветственное сообщение от консоли (первая строка)
         string welcome = childOutput.ReadLine();
         Log(string.Format("[CONSOLE] {0}", welcome));
      }

      private void btnSend_Click_1(object sender, EventArgs e)
      {
         string command = txtCommand.Text.Trim();
         if (string.IsNullOrEmpty(command))
         {
            return;
         }

         Log(string.Format(">> {0}", command));

         // Отправляем команду в stdin дочернего процесса
         childInput.WriteLine(command);
         childInput.Flush();  // гарантируем отправку

         // Синхронно читаем ответ из stdout (блокирует UI!)
         string response = childOutput.ReadLine();

         Log(string.Format("<< {0}", response));

         // Если это была команда EXIT, закрываем процесс
         if (command.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
         {
            childProcess.WaitForExit(1000);
            if (!childProcess.HasExited)
               childProcess.Kill();
            Log("Child process terminated.");
            btnSend.Enabled = false;
         }
      }

      private void Log(string message)
      {
         rtbLog.AppendText($"{message}{Environment.NewLine}");
      }

      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (childProcess != null && !childProcess.HasExited)
         {
            try
            {
               childInput?.WriteLine("EXIT");
               childInput?.Flush();
               childProcess?.WaitForExit(500);
            }
            catch { /* уже завершился */ }
            finally
            {
               childProcess?.Kill();
               childProcess?.Dispose();
            }
         }
      }
   }
}