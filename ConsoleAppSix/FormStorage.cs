using System.Windows.Forms;

namespace ConsoleAppSix
{
   public partial class FormStorage : Form
   {
      public FormStorage()
      {
         InitializeComponent();
         // Инициализируем форму данными из хранилища
         LoadDataFromStorage();
      }

      private void LoadDataFromStorage()
      {
         // Загружаем существующие данные из хранилища
         nameBox.Text = DataStorage.UserName ?? "Не задано";
         ageBox.Value = DataStorage.UserAge;
      }

      private void saveButton_Click(object sender, System.EventArgs e)
      {
         // Сохраняем данные в глобальное хранилище
         DataStorage.UserName = nameBox.Text;
         DataStorage.UserAge = (int)ageBox.Value;

         // Добавляем сообщение в список
         DataStorage.Messages.Add(
            $"Сохранено: {nameBox.Text}, возраст: {ageBox.Value}");

         displayLabel.Text = @"Данные сохранены в глобальное хранилище!";
      }

      private void showDataButton_Click(object sender, System.EventArgs e)
      {
         // Показываем все данные из хранилища
         string allData = $"Имя: {DataStorage.UserName}\n" +
                          $"Возраст: {DataStorage.UserAge}\n" +
                          $"Сообщений: {DataStorage.Messages.Count}";
         displayLabel.Text = allData;
      }
   }
}