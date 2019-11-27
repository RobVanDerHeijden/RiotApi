using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Summoner
    {
        [JsonProperty("id")] // encryptedSummonerId
        public string EncryptedSummonerId { get; set; }
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
        public Position PreferedPosition { get; set; }
        public Tag ChampTagStyle { get; set; }
        [JsonProperty("matches")]
        public List<PlayedGame> Games { get; set; }
        public LiveGame LiveGame { get; set; }
        public DateTime LastUpdated { get; set; }

        
        // TODO: seriously consider adding region to Summoner, could make api cals easier, since a summoner is always linked to ONE region
        public string Region { get; set; }

    }
}
