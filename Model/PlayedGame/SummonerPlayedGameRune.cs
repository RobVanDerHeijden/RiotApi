using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SummonerPlayedGameRune
    {
        public int RuneSlot { get; set; } // Known as perks
        public SummonerPlayedGame SummonerPlayedGame { get; set; }
        public Rune Rune { get; set; }
    }
}
