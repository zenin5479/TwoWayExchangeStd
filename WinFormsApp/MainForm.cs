using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
   public partial class MainForm : Form
   {
      private Process _childProcess;
      private StreamWriter _childInput;
      private StreamReader _childOutput;

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
            // Путь к консольному приложению
            FileName = "ConsoleApp.exe",
            UseShellExecute = false,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
         };

         _childProcess = new Process { StartInfo = startInfo };
         _childProcess.Start();

         // Получаем потоки
         _childInput = _childProcess.StandardInput;
         _childOutput = _childProcess.StandardOutput;

         // Читаем приветственное сообщение от консоли (первая строка)
         string welcome = _childOutput.ReadLine();
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
         _childInput.WriteLine(command);
         // Гарантируем отправку
         _childInput.Flush();

         // Синхронно читаем ответ из stdout (блокирует UI!)
         string response = _childOutput.ReadLine();

         Log(string.Format("<< {0}", response));

         // Если это была команда EXIT, закрываем процесс
         if (command.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
         {
            _childProcess.WaitForExit(1000);
            if (!_childProcess.HasExited)
            {
               _childProcess.Kill();
            }

            Log("Дочерний процесс завершен");
            btnReadCommand.Enabled = false;
         }
      }

      private void Log(string message)
      {
         rtbLog.AppendText(string.Format("{0}{1}", message, Environment.NewLine));
      }

      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (_childProcess != null && !_childProcess.HasExited)
         {
            try
            {
               _childInput.WriteLine("EXIT");
               _childInput.Flush();
               _childProcess.WaitForExit(500);
            }
            catch
            {
               /* уже завершился */
            }
            finally
            {
               _childProcess.Kill();
               _childProcess.Dispose();
            }
         }
      }
   }
}