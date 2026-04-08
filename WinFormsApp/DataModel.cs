using System;

namespace WinFormsApp
{
   public class DataModel
   {
      private string _consoleMessage;
      private string _formMessage;

      public string ConsoleMessage
      {
         get => _consoleMessage;
         set
         {
            _consoleMessage = value;
            OnMessageChanged?.Invoke(this, new MessageEventArgs("Console", value));
         }
      }

      public string FormMessage
      {
         get => _formMessage;
         set
         {
            _formMessage = value;
            OnMessageChanged?.Invoke(this, new MessageEventArgs("Form", value));
         }
      }

      public event EventHandler<MessageEventArgs> OnMessageChanged;
   }

   public class MessageEventArgs : EventArgs
   {
      public string Source { get; }
      public string Message { get; }

      public MessageEventArgs(string source, string message)
      {
         Source = source;
         Message = message;
      }
   }
}