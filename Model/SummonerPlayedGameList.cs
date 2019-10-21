using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SummonerPlayedGameList
    {
        public List<SummonerPlayedGame> Matches { get; set; }
        public int TotalGames { get; set; }
        //public int StartIndex { get; set; }
        //public int EndIndex { get; set; }
    }
}
