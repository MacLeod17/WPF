using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Title = "Garrick";
            if (e.Args.Length > 0)
            {
                int.TryParse(e.Args[0], out int width);
                window.Width = width;
            }
            window.Show();
        }
    }
}
