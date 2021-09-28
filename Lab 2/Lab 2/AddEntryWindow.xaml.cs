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

namespace Lab_2
{
    /// <summary>
    /// Interaction logic for AddEntryWindow.xaml
    /// </summary>
    public partial class AddEntryWindow : Window
    {
        string[] entry = new string[5];
        public AddEntryWindow()
        {
            InitializeComponent();
        }

        private void AddEntryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AnswerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DifficultyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
