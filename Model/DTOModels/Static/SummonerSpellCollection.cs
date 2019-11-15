using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model.DTOModels
{
    public class SummonerSpellCollection
    {
        [JsonProperty("type")]
        public string CollectionType { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, SummonerSpell> SummonerSpellInfos { get; set; }
        public List<SummonerSpell> SummonerSpellInfoList { get; set; }
    }
}
