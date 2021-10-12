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

namespace Lab_4
{
    /// <summary>
    /// Interaction logic for DeleteEntryWindow.xaml
    /// </summary>
    public partial class DeleteEntryWindow : Window
    {
        UserInterface Ui = new UserInterface();
        public DeleteEntryWindow()
        {
            InitializeComponent();
        }

        private void DeleteEntryButton_Click(object sender, RoutedEventArgs e)
        {
            if (Ui.DeleteEntry(IdTextBox.Text).Equals(""))
            {
                IdTextBox.Clear();
                Hide();
            }
            else if (Ui.DeleteEntry(IdTextBox.Text).Equals("INVALID ID"))
            {
                MessageBox.Show("INVALID ID", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                IdTextBox.Clear();
            }
            else if (Ui.DeleteEntry(IdTextBox.Text).Equals("UNABLE TO FIND ID"))
            {
                MessageBox.Show("UNABLE TO FIND ID", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                IdTextBox.Clear();
            }
            else
            {
                MessageBox.Show("UNKNOWN ERROR", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
