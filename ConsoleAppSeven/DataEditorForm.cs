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
         int i = 0;
         while (i < GlobalDataStore.People.Count)
         {
            Person person = GlobalDataStore.People[i];
            dataListBox.Items.Add(person);
            i++;
         }
      }

      private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (dataListBox.SelectedIndex >= 0)
         {
            Person person = GlobalDataStore.People[dataListBox.SelectedIndex];
            nameTextBox.Text = person.Name;
            ageTextBox.Text = person.Age.ToString();
            emailTextBox.Text = person.Email;
            selectedIndexLabel.Text = string.Format(@"Выбран элемент: {0}", dataListBox.SelectedIndex + 1);
         }
      }

      private void addButton_Click(object sender, EventArgs e)
      {
         if (int.TryParse(ageTextBox.Text, out int age))
         {
            Person newPerson = new Person
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
            int selectedIndex = dataListBox.SelectedIndex;
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

      private void buttonClear_Click(object sender, EventArgs e)
      {
         // Ни один элемент не выбран
         dataListBox.SelectedIndex = -1;

         // Ни один элемент не выбран
         dataListBox.SelectedItem = null;
         
         if ()
         {

         }
      }
   }
}