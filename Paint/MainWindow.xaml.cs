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
using Xceed.Wpf.Toolkit;

namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void cboBrushSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetBrushSize(sender);
        }

        private void cboBrushSize_DropDownClosed(object sender, EventArgs e)
        {
            SetBrushSize(sender);
        }

        private void SetBrushSize(object sender)
        {
            string text = ((ComboBox)sender).Text;

            if (text.Length > 0)
            {
                int size = int.Parse(text);
                BrushAttrib.Width = size;
                BrushAttrib.Height = size;
            }
        }

        private void Color_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            ColorPicker colorPicker = (ColorPicker)sender;
            if (colorPicker != null)
            {
                BrushAttrib.Color = (Color)colorPicker.SelectedColor;
            }
        }
    }
}
