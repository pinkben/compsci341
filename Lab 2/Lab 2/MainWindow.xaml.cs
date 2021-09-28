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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserInterface Ui = new UserInterface();
        AddEntryWindow addEntryWindow = new AddEntryWindow();
        DeleteEntryWindow deleteEntryWindow = new DeleteEntryWindow();
        EditEntryIdWindow editEntryIdWindow = new EditEntryIdWindow();

        public MainWindow()
        {
            InitializeComponent();
            addEntryWindow.Hide();
            deleteEntryWindow.Hide();
            editEntryIdWindow.Hide();
        }

        private void ListAllEntriesButton_Click(object sender, RoutedEventArgs e)
        {
            String result = Ui.ListEntries();
            EntriesTextBox.Clear();
            EntriesTextBox.AppendText(result);
        }

        private void AddEntryButton_Click(object sender, RoutedEventArgs e)
        {
            addEntryWindow.Show();
        }

        private void UpdateEntryButton_Click(object sender, RoutedEventArgs e)
        {
            editEntryIdWindow.Show();
        }

        private void DeleteEntryButton_Click(object sender, RoutedEventArgs e)
        {
            deleteEntryWindow.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            addEntryWindow.Close();
            deleteEntryWindow.Close();
            editEntryIdWindow.CloseWindow();
            Close();
        }
    }
}
