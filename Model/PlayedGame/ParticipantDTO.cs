using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class ParticipantDTO
    {
        public int ParticipantId { get; set; }
        public int TeamId { get; set; }
        public int ChampionId { get; set; }
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
        public string HighestAchievedSeasonTier { get; set; }
        public ParticipantStatsDTO Stats { get; set; }
        public ParticipantTimelineDTO Timeline { get; set; }
        
        // Deze zijn van oud seizoen / depricated
        // List[RuneDto]
        // List[MasteryDto]
    }
}
