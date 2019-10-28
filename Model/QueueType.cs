using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class QueueType
    {
        [JsonProperty("queueId")]
        public int IdQueue { get; set; }
        public Map Map { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string DisplayName { get; set; }
        
    }
}
