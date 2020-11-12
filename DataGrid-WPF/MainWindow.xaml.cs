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

namespace DataGrid_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Game> games = new List<Game>();

            games.Add(new Game()
            {
                ID = 1,
                Title = "Resident Evil",
                Publisher = "Capcom",
                Release = new DateTime(1996, 3, 22),
                IsUsed = true,
                ImageURL = "https://i5.walmartimages.com/asr/1ad65a6b-a06f-4a12-bc55-afe149928ab4_1.d97c343b095b43d849ae656aef9becf2.jpeg"
            });

            games.Add(new Game()
            {
                ID = 2,
                Title = "Dying Light",
                Publisher = "Techland",
                Release = new DateTime(2015, 1, 26),
                IsUsed = false,
                ImageURL = "https://media.gamestop.com/i/gamestop/10111375/Dying-Light?$pdp$&bg=rgb(0,0,0)"
            });

            games.Add(new Game()
            {
                ID = 3,
                Title = "Dishonored",
                Publisher = "Bethesda",
                Release = new DateTime(2012, 10, 8),
                IsUsed = true,
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/6/65/Dishonored_box_art_Bethesda.jpg"
            });

            dgdGames.ItemsSource = games;
        }
    }
}
