using System.Collections.Generic;

namespace ConsoleAppSix
{
   public static class DataStorage
   {
      private static Dictionary<string, object> _settings = new Dictionary<string, object>();

      // Простые типы данных
      public static string UserName { get; set; }
      public static int UserAge { get; set; }

      // Сложные типы
      public static List<string> Messages { get; set; } = new List<string>();

      public static Dictionary<string, object> Settings
      {
         get { return _settings; }
      }

      // Временные данные
      public static bool IsFormActive { get; set; }

      // Метод для сброса всех данных
      public static void ClearAll()
      {
         UserName = null;
         UserAge = 0;
         Messages.Clear();
         Settings.Clear();
      }
   }
}