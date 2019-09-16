using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{ 
    public class MatchParticipantFrameDTO
    {
        public int ParticipantId { get; set; }
        public MatchPositionDTO Position { get; set; }
        public int CurrentGold { get; set; }
        public int TotalGold { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int MinionsKilled { get; set; }
        public int JungleMinionsKilled { get; set; }
        public int DominionScore { get; set; }
        public int TeamScore { get; set; }
    }
}
