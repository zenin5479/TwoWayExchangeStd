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
            if (input == null) break; // EOF – родитель закрыл stdin

            string output = input.ToUpperInvariant() switch
            {
               "PING" => "PONG",
               "TIME" => DateTime.Now.ToString("HH:mm:ss"),
               "EXIT" => "BYE",
               _ => $"UNKNOWN COMMAND: {input}"
            };

            Console.WriteLine(output);

            if (input.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
               break;
         }
      }
   }
}