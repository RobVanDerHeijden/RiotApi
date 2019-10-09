using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TeamSummoner
    {
        public bool IsSubstitute { get; set; }
        public Team Team { get; set; }
        public Summoner Summoner { get; set; }
    }
}
