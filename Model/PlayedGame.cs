using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class PlayedGame
    {
        public long GameId { get; set; }
        public long Timestamp { get; set; }
        public DateTime DateCreated { get; set; }
        public int Duration { get; set; }
        public int Season { get; set; } // TODO: Check if this is nessecary, because DateCreated can also be indication of season
        public QueueType QueueType { get; set; }

    }
}
