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
         nameBox.Text = DataStorage.UserName;
         ageBox.Value = DataStorage.UserAge;
      }

      private void saveButton_Click(object sender, System.EventArgs e)
      {
         // Сохраняем данные в глобальное хранилище
         DataStorage.UserName = nameBox.Text;
         DataStorage.UserAge = (int)ageBox.Value;

         // Добавляем сообщение в список
         DataStorage.Messages.Add(string.Format("Сохранено: {0}, возраст: {1}", nameBox.Text, ageBox.Value));

         displayLabel.Text = @"Данные сохранены в глобальное хранилище";
      }

      private void showDataButton_Click(object sender, System.EventArgs e)
      {
         // Показываем все данные из хранилища
         string allData = string.Format("Имя: {0}\n", DataStorage.UserName) +
                          string.Format("Возраст: {0}\n", DataStorage.UserAge) +
                          string.Format("Сообщений: {0}", DataStorage.Messages.Count);
         displayLabel.Text = allData;
      }
   }
}