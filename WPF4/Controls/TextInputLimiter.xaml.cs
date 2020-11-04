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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF4.Controls
{
    /// <summary>
    /// Interaction logic for TextInputLimiter.xaml
    /// </summary>
    public partial class TextInputLimiter : UserControl
    {
        public string Info { get; set; }
        public int MaxLength { get; set; }

        public TextInputLimiter()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
