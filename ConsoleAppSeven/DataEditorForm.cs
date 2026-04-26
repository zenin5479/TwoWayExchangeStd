using System;
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
         for (int i = 0; i < GlobalDataStore.People.Count; i++)
         {
            Person person = GlobalDataStore.People[i];
            dataListBox.Items.Add(person);
         }
      }

      private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (dataListBox.SelectedIndex >= 0)
         {
            var person = GlobalDataStore.People[dataListBox.SelectedIndex];
            nameTextBox.Text = person.Name;
            ageTextBox.Text = person.Age.ToString();
            emailTextBox.Text = person.Email;
            selectedIndexLabel.Text = $"Выбран элемент: {dataListBox.SelectedIndex + 1}";
         }
      }

      private void addButton_Click(object sender, EventArgs e)
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
            MessageBox.Show(@"Некорректный возраст!");
         }
      }

      private void saveButton_Click(object sender, EventArgs e)
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
            MessageBox.Show(@"Данные обновлены!");
         }
         else
         {
            MessageBox.Show(@"Выберите элемент и введите корректный возраст!");
         }
      }

      private void deleteButton_Click(object sender, EventArgs e)
      {
         if (dataListBox.SelectedIndex >= 0)
         {
            GlobalDataStore.People.RemoveAt(dataListBox.SelectedIndex);
            LoadData();
            ClearInputs();
            MessageBox.Show(@"Элемент удалён!");
         }
         else
         {
            MessageBox.Show(@"Выберите элемент для удаления!");
         }
      }

      private void ClearInputs()
      {
         nameTextBox.Clear();
         ageTextBox.Clear();
         emailTextBox.Clear();
      }
   }
}