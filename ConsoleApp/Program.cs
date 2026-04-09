using System;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Консоль готова. Ждем команд...");

         while (true)
         {
            string input = Console.ReadLine();
            if (input == null)
            {
               // EOF – родитель закрыл stdin
               break;
            }

            string output;
            if (input.ToUpperInvariant() == "PING")
            {
               output = "PONG";
            }
            else if (input.ToUpperInvariant() == "TIME")
            {
               output = DateTime.Now.ToString("HH:mm:ss:fff");
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