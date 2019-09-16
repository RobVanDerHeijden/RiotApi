using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class MatchDTO
    {
        public long GameId { get; set; }
        public string PlatformId { get; set; }
        public long GameCreation { get; set; }
        public long GameDuration { get; set; }
        public int QueueId { get; set; }
        public int MapId { get; set; }
        public int SeasonId { get; set; }
        public string GameVersion { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }
        public Dictionary<string, TeamStatsDTO> Teams { get; set; }
        public Dictionary<string, ParticipantDTO> Participants { get; set; }
        public Dictionary<string, ParticipantIdentityDTO> ParticipantIdentities { get; set; }
    }
}
