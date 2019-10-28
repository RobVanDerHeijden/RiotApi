using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class PlayedGame
    {
        public long GameId { get; set; }
        [JsonProperty("gameCreation")]
        public long Timestamp { get; set; }
        public DateTime DateCreated { get; set; }
        public int Duration { get; set; }
        public int Season { get; set; } // TODO: Check if this is nessecary, because DateCreated can also be indication of season
        [JsonProperty("queueId")]
        public int QueueTypeId { get; set; }
        public QueueType QueueType { get; set; }

    }
}
