using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Item
    {
        public int Key { get; set; }
        public string Name { get; set; }
        [JsonProperty("plaintext")]
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        // "base": int, "purchasable": bool, "total": int, "sell": int
        [JsonProperty("gold")]
        public Dictionary<string, dynamic> ItemGoldInfos { get; set; }

        //public int BaseGold { get; set; } // Cost to buy with ingredient items ready
        //public int TotalGold { get; set; } // Cost to buy without ingredient items
        //public int SellGold { get; set; }
    }
}
