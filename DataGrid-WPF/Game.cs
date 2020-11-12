using System;
using System.Collections.Generic;
using System.Text;

namespace DataGrid_WPF
{
    class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime Release { get; set; }
        public bool IsUsed { get; set; }

        public string Information { get { return $"{Title} was released by {Publisher} on {Release}."; } }
        public string ImageURL { get; set; }
    }
}
