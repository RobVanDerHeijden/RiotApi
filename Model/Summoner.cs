using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string SummonerId { get; set; }
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        public string HighestPreviousRank { get; set; }
        [JsonProperty("revisionDate")]
        public long RevisionDateLong { get; set; } // comes in as long, TODO: convert with epoch to Datetime
        public Lane PreferedPosition { get; set; }
        public Tag ChampTagStyle { get; set; }
        public List<PlayedGame> Games { get; set; }
        public LiveGame LiveGame { get; set; }

    }
}
