using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Rune
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("key")]
        public int Key { get; set; }
        [JsonProperty("name")]
        public string KeyName { get; set; }
        //[JsonProperty("icon")]
        //public string ImageLocation { get; set; }
        [JsonProperty("shortDesc")]
        public string ShortDescription { get; set; }
        [JsonProperty("longDesc")]
        public string LongDescription { get; set; }
    }
}
