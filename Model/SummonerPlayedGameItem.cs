using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SummonerPlayedGameItem
    {
        public int ItemSlot { get; set; } // 0 -> 6
        public SummonerPlayedGame SummonerPlayedGame { get; set; }
        public Item Item { get; set; }
    }
}
