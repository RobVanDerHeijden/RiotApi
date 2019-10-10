using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Summoner
    {
        public int IdSummoner { get; set; }
        public int IdAccount { get; set; }
        public string Name { get; set; }
        public int SummonerLevel { get; set; }
        public int ProfileIconId { get; set; }
        public string HighestPreviousRank { get; set; }
        public long RevisionDateLong { get; set; } // comes in as long, TODO: convert with epoch to Datetime
        public DateTime LastUpdated { get; set; }
        public Lane PreferedPosition { get; set; }
        public Tag ChampTagStyle { get; set; }
        public List<PlayedGame> Games { get; set; }
        public LiveGame LiveGame { get; set; }

    }
}
