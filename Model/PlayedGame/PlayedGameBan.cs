using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class PlayedGameBan
    {
        public int PickTurn { get; set; }
        public int Team { get; set; }
        public PlayedGame PlayedGame { get; set; }
        public Champion Champion { get; set; }
    }
}
