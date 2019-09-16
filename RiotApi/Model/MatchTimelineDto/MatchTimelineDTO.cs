using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class MatchTimelineDTO
    {
        public Dictionary<string, MatchFrameDTO> Frames { get; set; }
        public int FrameInterval { get; set; }
    }
}
