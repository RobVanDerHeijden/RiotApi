using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class SummonerPlayedGamesList
    {
        [JsonProperty("matches")]
        public List<PlayedGame> Matches { get; set; }
        public Summoner Summoner { get; set; }
        public int TotalGames { get; set; }
        
        //public int StartIndex { get; set; }
        //public int EndIndex { get; set; }
    }
}
