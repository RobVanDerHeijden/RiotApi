using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Rank
    {
        public string Division { get; set; }
        public int LeaguePoints { get; set; } // LP
        public int Wins { get; set; }
        public int Losses { get; set; }
        public Summoner Summoner { get; set; }
        public League League { get; set; }
        public QueueType QueueType { get; set; }

    }
}
