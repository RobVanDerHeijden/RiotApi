using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ChampionSpell
    {
        public string KeySpell { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Cooldown { get; set; }
        public string ParType { get; set; } // Mana, Energy etc.
        public List<int> Cost { get; set; }
        public List<int> Range { get; set; }
        public Champion Champion { get; set; }

    }
}
