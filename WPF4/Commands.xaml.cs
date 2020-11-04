using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF4
{
    /// <summary>
    /// Interaction logic for Commands.xaml
    /// </summary>
    public partial class Commands : Window
    {
        public Commands()
        {
            InitializeComponent();
        }

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtInput != null && txtInput.SelectionLength > 0);
        }

        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtInput.Cut();
        }

        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtInput.Paste();
        }

        private void Copy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtInput != null && txtInput.SelectionLength > 0);
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtInput.Copy();
        }

        private void Exit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Submit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtInput != null && txtInput.Text.Length > 0);
        }

        private void Submit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Submitted!");
        }
    }
}
