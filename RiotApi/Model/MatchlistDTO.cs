using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class MatchlistDTO
    {
        public Dictionary<string, MatchReferenceDTO> Matches { get; set; }
        public int TotalGames { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}
