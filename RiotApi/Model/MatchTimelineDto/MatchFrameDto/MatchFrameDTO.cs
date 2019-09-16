using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class MatchFrameDTO
    {
        public Dictionary<string, MatchParticipantFrameDTO> ParticipantFrames { get; set; }
        public Dictionary<string, MatchEventDTO> Events { get; set; }
        public long Timestamp { get; set; }
    }
}
