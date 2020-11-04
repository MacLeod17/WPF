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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Width = 100;
            btn.Content = "Bro!";
            pnlMain.Children.Add(btn);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click!");
        }

        private void cbxEnable_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            btn1.IsEnabled = false;
            Console.Beep();
        }

        private void cbxEnable_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            btn1.IsEnabled = (bool)cbxEnable.IsChecked;
        }
    }
}
