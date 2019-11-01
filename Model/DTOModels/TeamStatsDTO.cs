using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class TeamStatsDTO
    {
        public int TeamId { get; set; }
        public string Win { get; set; }
        public bool FirstBlood { get; set; }
        public bool FirstTower { get; set; }
        public bool FirstInhibitor { get; set; }
        public bool FirstBaron { get; set; }
        public bool FirstDragon { get; set; }
        public bool FirstRiftHerald { get; set; }
        public int TowerKills { get; set; }
        public int InhibitorKills { get; set; }
        public int BaronKills { get; set; }
        public int DragonKills { get; set; }
        public int VilemawKills { get; set; }
        public int RiftHeraldKills { get; set; }
        public int DominionVictoryScore { get; set; }
        public Dictionary<string, TeamBansDTO> Bans { get; set; }
    }
}
