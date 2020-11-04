using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF2
{
    /// <summary>
    /// Interaction logic for BindingWindow.xaml
    /// </summary>
    public partial class BindingWindow : Window
    {
        ObservableCollection<Character> characters = new ObservableCollection<Character>();

        public BindingWindow()
        {
            InitializeComponent();

            DataContext = this;

            characters.Add(new Character() { Name = "Slim" });
            characters.Add(new Character() { Name = "Fred" });
            characters.Add(new Character() { Name = "Greg" });
            lstCharacters.ItemsSource = characters;

            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            txtValueBind.SetBinding(TextBlock.TextProperty, binding);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            characters.Add(new Character() { Name = "Default" });
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstCharacters.SelectedItem != null)
            {
                characters.Remove((Character)lstCharacters.SelectedItem);
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (lstCharacters.SelectedItem != null)
            {
                ((Character)lstCharacters.SelectedItem).Name = "New Name";
            }
        }
    }
}
