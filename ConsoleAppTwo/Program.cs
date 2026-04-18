using System;
using System.Windows.Forms;

// Двусторонний обмен через публичные свойства

namespace ConsoleAppTwo
{
   internal class Program
   {
      static void Main()
      {
         // Консоль передаёт данные в форму
         Console.Write(@"Введите ваше имя: ");
         string userName = Console.ReadLine();

         // Включаем визуальные стили (опционально)
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         // Создаём форму, передавая начальные данные через конструктор
         DataForm myForm = new DataForm(userName);

         // Показываем форму (консоль ждёт)
         Console.WriteLine(@"Открываем форму... Введите данные в окне и закройте его");
         // Здесь выполнение консоли останавливается
         Application.Run(myForm);

         // Часть 3: Форма закрыта, читаем результаты, получаем данные из публичных свойств формы
         bool userChoice = myForm.UserAgreed;
         string userComment = myForm.UserComment;

         Console.WriteLine(@"Форма закрыта. Получены данные:");
         Console.WriteLine(@"Пользователь согласился: {0}", userChoice);
         Console.WriteLine(@"Комментарий: {0}", userComment);

         Console.WriteLine(@"Нажмите любую клавишу для выхода...");
         Console.ReadKey();
      }
   }
}