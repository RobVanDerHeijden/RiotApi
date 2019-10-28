using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SummonerPlayedGame
    {
        public int IdProfileIcon { get; set; }
        public string GameResult { get; set; } // Values can be: Win, Fail TODO: find out what value is used for a remake
        public int ChampionLevel { get; set; }
        public int Team { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int CreepScore { get; set; } // CS
        public float CreepScorePerMinute { get; set; }
        public int BiggestMultiKill { get; set; }
        public int TotalDamageDealtToChampions { get; set; }
        public int VisionScore { get; set; }
        public bool FirstBlood { get; set; }
        public bool IsBot { get; set; }
        public Summoner Summoner { get; set; }
        public long GameId { get; set; } 
        public PlayedGame GameIdObject { get; set; }
        public int Champion { get; set; } 
        public Champion ChampionObject { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }
        public Position Position { get; set; }
    }
}
