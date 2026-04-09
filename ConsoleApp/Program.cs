using System;
using System.Windows.Forms;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main()
      {
         // Часть 1: Консоль передаёт данные в форму
         Console.Write("Введите ваше имя: ");
         string userName = Console.ReadLine();

         // Включаем визуальные стили (опционально)
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаём форму, передавая начальные данные через конструктор
         DataForm myForm = new DataForm(userName);

         // --- Часть 2: Показываем форму (консоль ждёт) ---
         Console.WriteLine("Открываем форму... Введите данные в окне и закройте его.");
         Application.Run(myForm); // Здесь выполнение консоли останавливается

         // --- Часть 3: Форма закрыта, читаем результаты ---
         // Получаем данные из публичных свойств формы
         bool userChoice = myForm.UserAgreed;
         string userComment = myForm.UserComment;

         Console.WriteLine("\nФорма закрыта. Получены данные:");
         Console.WriteLine($"Пользователь согласился: {userChoice}");
         Console.WriteLine($"Комментарий: {userComment}");

         Console.WriteLine("\nНажмите любую клавишу для выхода...");
         Console.ReadKey();
      }
   }
}