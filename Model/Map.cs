using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Map
    {
        [JsonProperty("mapId")]
        public int IdMap { get; set; }
        [JsonProperty("mapName")]
        public string Name { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }

    }
}
