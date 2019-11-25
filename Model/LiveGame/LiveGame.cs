using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class LiveGame
    {
        public int IdGame { get; set; }
        public DateTime GameStartTime { get; set; }
        public int GameLength { get; set; }
        public QueueType QueueType { get; set; }
    }
}
