using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Rank
    {
        [JsonProperty("rank")]
        public string Division { get; set; }
        public string Tier { get; set; }
        public int LeaguePoints { get; set; } // LP
        public int Wins { get; set; }
        public int Losses { get; set; }
        public Summoner Summoner { get; set; }
        public League League { get; set; }
        public string QueueType { get; set; }
        public QueueType QueueTypeObject { get; set; }

    }
}
