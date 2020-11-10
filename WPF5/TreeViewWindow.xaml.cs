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

namespace WPF5
{
    
    public partial class TreeViewWindow : Window
    {
        public TreeViewWindow()
        {
            InitializeComponent();

            Uri uri = new Uri("pack://application:,,,/Resources/sus.bmp");
            BitmapImage image = new BitmapImage(uri);

            MenuItem root = new MenuItem() { Title = "Root", Icon = image };
            MenuItem child1 = new MenuItem() { Title = "Child 1", Icon = image };
            child1.Items.Add(new MenuItem { Title = "Child 1.1", Icon = image });
            child1.Items.Add(new MenuItem { Title = "Child 1.2", Icon = image });
            root.Items.Add(child1);
            root.Items.Add(new MenuItem { Title = "Child 2", Icon = image });

            trvMenu.Items.Add(root);
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }
        public BitmapImage Icon { get; set; }
        public ObservableCollection<MenuItem> Items { get; set; }

        public MenuItem()
        {
            Items = new ObservableCollection<MenuItem>();
        }
    }
}
