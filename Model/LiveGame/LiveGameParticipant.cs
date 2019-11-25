using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class LiveGameParticipant
    {
        public int Team { get; set; }
        public Summoner Summoner { get; set; }
        public SummonerSpell SummonerSpell1 { get; set; }
        public SummonerSpell SummonerSpell2 { get; set; }
        public Champion Champion { get; set; }
    }
}
