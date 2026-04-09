using System;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Console ready. Waiting for commands...");

         while (true)
         {
            string input = Console.ReadLine();
            if (input == null)
            {
               break; // EOF – родитель закрыл stdin
            }

            string output;
            if (input.ToUpperInvariant() == "PING")
            {
               output = "PONG";
            }
            else if (input.ToUpperInvariant() == "TIME")
            {
               output = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (input.ToUpperInvariant() == "EXIT")
            {
               output = "BYE";
            }
            else
            {
               output = string.Format("UNKNOWN COMMAND: {0}", input);
            }

            Console.WriteLine(output);

            if (input.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
            {
               break;
            }
         }
      }
   }
}