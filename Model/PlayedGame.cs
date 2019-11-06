using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RiotApi.Model;

namespace Model
{
    public class PlayedGame
    {
        public long GameId { get; set; }
        [JsonProperty("gameCreation")]
        public long Timestamp { get; set; }
        public DateTime DateCreated { get; set; }
        [JsonProperty("gameDuration")]
        public int Duration { get; set; }
        [JsonProperty("seasonId")]
        public int Season { get; set; }
        [JsonProperty("queueId")]
        public int QueueTypeId { get; set; }
        public QueueType QueueType { get; set; }
        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentityDTO> ParticipantIdentities { get; set; }
        [JsonProperty("participants")]
        public List<ParticipantDTO> Participants { get; set; }
        
        public List<TeamStatsDTO> Teams { get; set; }
        [JsonProperty("teams")]
        public List<PlayedGameTeam> PlayedGameTeams { get; set; }

    }
}
