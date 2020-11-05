using Match_Game.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace Match_Game
{
    public partial class GameWindow : Window
    {
        private Random gen = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        private List<Card> cards = new List<Card>();
        private List<string> symbols = new List<string>()
        {
            "!", "!", "N", "N", ",", ",",
            "b", "b", "v", "v", "w", "w",
        };

        public int Tries { get; set; } = 0;
        private Card card1 = null;
        private Card card2 = null;

        public GameWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTick;
        }

        public void RegisterCard(Card card)
        {
            card.State = Card.eState.Idle;
            int index = gen.Next(symbols.Count);
            card.Symbol = symbols[index];
            symbols.RemoveAt(index);
            cards.Add(card);
        }

        public void SelectCard(Card card)
        {
            if (card1 == null)
            {
                // Set card1 to card
                card1 = card;
            }
            else
            {
                // Set card2 to card
                Tries++;
                card2 = card;

                if (card1.Symbol == card2.Symbol) // Check for Matching Cards (card1, card2). Compare card Symbols
	            {
                    // Set card1 and card2 State to Matched; Set card1 and card2 to null
                    card1.State = Card.eState.Matched;
                    card2.State = Card.eState.Matched;
                    card1 = null;
                    card2 = null;
                }

                else
                {
                    // Disable All Cards, so They Can’t be Selected for a Second
                    // This Allows the Player to see the Flipped Card for a Moment
                    foreach (var c in cards) // Iterate Through All Cards
		            {
                        if (c.State == Card.eState.Idle)// If card State is Idle
                        {
                            // Set card State to Inactive
                            c.State = Card.eState.Inactive;
                        }
                    }
                    // Start timer, After a Second the TimerTick is Called and the Cards Reset
                    timer.Start();
                    timer.Tick += TimerTick;
                }
            }
            txtTries.Text = "Tries: " + Tries.ToString();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            foreach (var c in cards)
            {
                if (c.State != Card.eState.Matched)
                {
                    c.State = Card.eState.Idle;
                }
            }
            card1 = null;
            card2 = null;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            var currentExecutablePath = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(currentExecutablePath);
            Application.Current.Shutdown();
        }
    }
}
