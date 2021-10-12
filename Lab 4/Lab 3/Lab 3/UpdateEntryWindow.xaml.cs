using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_3
{
    /// <summary>
    /// Interaction logic for AddEntryWindow.xaml
    /// </summary>
    public partial class UpdateEntryWindow : Window
    {
        UserInterface Ui = new UserInterface();
        private string id;
        public UpdateEntryWindow()
        {
            InitializeComponent();
            Hide();
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        private void UpdateEntryButton_Click(object sender, RoutedEventArgs e)
        {
            string[] entry = new string[5];
            entry[0] = ClueTextBox.Text;
            entry[1] = AnswerTextBox.Text;
            entry[2] = DifficultyTextBox.Text;
            entry[3] = DateTextBox.Text;
            entry[4] = id;
            if (Ui.EditEntry(entry).Equals(""))
            {
                ClueTextBox.Clear();
                AnswerTextBox.Clear();
                DifficultyTextBox.Clear();
                DateTextBox.Clear();
                Hide();
            }
            else if (Ui.AddEntry(entry).Equals("INVALID CLUE"))
            {
                MessageBox.Show("INVALID CLUE", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                ClueTextBox.Clear();
            }
            else if (Ui.AddEntry(entry).Equals("INVALID ANSWER"))
            {
                MessageBox.Show("INVALID ANSWER", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                AnswerTextBox.Clear();
            }
            else if (Ui.AddEntry(entry).Equals("INVALID DIFFICULTY"))
            {
                MessageBox.Show("INVALID DIFFICULTY", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                DifficultyTextBox.Clear();
            }
            else if (Ui.AddEntry(entry).Equals("INVALID DATE"))
            {
                MessageBox.Show("INVALID DATE", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                DateTextBox.Clear();
            }
            else
            {
                MessageBox.Show("UNKNOWN ERROR", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
