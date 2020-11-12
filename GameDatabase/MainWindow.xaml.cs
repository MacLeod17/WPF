using GameDatabase.DataSetTableAdapters;
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

namespace GameDatabase
{
    
    public partial class MainWindow : Window
    {
        private GameTableAdapter gameTableAdapter = new GameTableAdapter();
        private DataSet dataSet = new DataSet();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Fill(dataSet.Game);
            DataContext = dataSet.Game.DefaultView;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Update(dataSet);
        }
    }
}
