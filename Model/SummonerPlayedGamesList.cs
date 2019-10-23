using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SummonerPlayedGamesList
    {
        public List<SummonerPlayedGame> Matches { get; set; }
        public Summoner Summoner { get; set; }
        public int TotalGames { get; set; }
        //public int StartIndex { get; set; }
        //public int EndIndex { get; set; }
    }
}
