using System.Windows.Forms;

namespace ConsoleAppSeven
{
   public partial class DataEditorForm : Form
   {
      public DataEditorForm()
      {
         InitializeComponent();
         LoadData();
      }

      private void LoadData()
      {
         dataListBox.Items.Clear();
         foreach (var person in GlobalDataStore.People)
         {
            dataListBox.Items.Add(person.ToString());
         }
      }

      private void addButton_Click(object sender, System.EventArgs e)
      {
         if (int.TryParse(ageTextBox.Text, out int age))
         {
            var newPerson = new Person
            {
               Name = nameTextBox.Text,
               Age = age,
               Email = emailTextBox.Text
            };
            GlobalDataStore.People.Add(newPerson);
            LoadData();
            ClearInputs();
         }
         else
         {
            MessageBox.Show("Некорректный возраст!");
         }
      }

      private void saveButton_Click(object sender, System.EventArgs e)
      {
         if (dataListBox.SelectedIndex >= 0 && int.TryParse(ageTextBox.Text, out int age))
         {
            var selectedIndex = dataListBox.SelectedIndex;
            GlobalDataStore.People[selectedIndex] = new Person
            {
               Name = nameTextBox.Text,
               Age = age,
               Email = emailTextBox.Text
            };
            LoadData();
            MessageBox.Show("Данные обновлены!");
         }
         else
         {
            MessageBox.Show("Выберите элемент и введите корректный возраст!");
         }
      }

      private void deleteButton_Click(object sender, System.EventArgs e)
      {
         if (dataListBox.SelectedIndex >= 0)
         {
            GlobalDataStore.People.RemoveAt(dataListBox.SelectedIndex);
            LoadData();
            ClearInputs();
            MessageBox.Show("Элемент удалён!");
         }
         else
         {
            MessageBox.Show("Выберите элемент для удаления!");
         }
      }
   }
}