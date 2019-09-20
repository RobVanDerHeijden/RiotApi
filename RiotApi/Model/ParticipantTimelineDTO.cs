using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class ParticipantTimelineDTO
    {
        public int ParticipantId { get; set; }
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }
        public Dictionary<string, double> XpPerMinDeltas { get; set; }
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }
        public int Role { get; set; }
        public int Lane { get; set; }

        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; } // 0-end, 0-10 , 10-end , 10-20 , etc
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }
    }
}
