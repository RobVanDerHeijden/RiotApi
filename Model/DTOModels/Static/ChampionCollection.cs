using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model.DTOModels
{
    public class ChampionCollection
    {
        [JsonProperty("type")]
        public string CollectionType { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, Champion> ChampionInfos { get; set; }
        public List<Champion> ChampionInfoList { get; set; }
    }
}
