using System.Collections.Generic;

namespace ConsoleAppSix
{
   public static class DataStorage
   {
      // Простые типы данных
      public static string UserName { get; set; }
      public static int UserAge { get; set; }

      // Сложные типы
      public static List<string> Messages { get; set; } = new List<string>();
      public static Dictionary<string, object> Settings { get; set; } = new Dictionary<string, object>();

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