using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model.DTOModels.Static
{
    public class ItemCollection
    {
        [JsonProperty("type")]
        public string CollectionType { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, Item> ItemInfos { get; set; }
        public List<Item> ItemInfoList { get; set; }
    }
}
