using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class SummonerSpell
    {
        [JsonProperty("key")]
        public int Key { get; set; }
        [JsonProperty("id")]
        public string KeyName { get; set; }
        [JsonProperty("name")]
        public string SummonerSpellName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        // TODO: Already got description, is this needed
        //[JsonProperty("tooltip")]
        //public string Tooltip { get; set; }
        [JsonProperty("cooldownBurn")]
        public string Cooldown { get; set; }
        // TODO: Since every spell has range, but it doenst make sense with every sumspell, check if i want this
        //[JsonProperty("rangeBurn")]
        //public string Range { get; set; } 
        // TODO: If i want to use imagesheets, for smaller images and less data used
        //[JsonProperty("image")]
        //public ImageInfo ImageInfo { get; set; }
    }
}
