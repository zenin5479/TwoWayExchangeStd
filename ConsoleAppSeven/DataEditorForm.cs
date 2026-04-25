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
   }
}