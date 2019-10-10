using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SummonerChampion
    {
        public int MasteryLevel { get; set; }
        public int MasteryPoints { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public DateTime LastTimePlayed { get; set; }
        public Summoner Summoner { get; set; }
        public Champion Champion { get; set; }
    }
}
