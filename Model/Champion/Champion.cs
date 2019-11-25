using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class Champion
    {
        [JsonProperty("key")]
        public int Key { get; set; }
        [JsonProperty("id")]
        public string KeyName { get; set; }
        [JsonProperty("name")]
        public string ChampionName { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("blurb")]
        public string Description { get; set; }

        //// TODO: Move these into-> public Stats Stats { get; set; }
        //[JsonProperty("hp")]
        //public float Hp { get; set; }
        //[JsonProperty("hpperlevel")]
        //public float HpPerLevel { get; set; }
        //[JsonProperty("mp")]
        //public float Mp { get; set; }
        //[JsonProperty("mpperlevel")]
        //public float MpPerLevel { get; set; }
        //[JsonProperty("armor")]
        //public float Armor { get; set; }
        //[JsonProperty("armorperlevel")]
        //public float ArmorPerLevel { get; set; }
        //[JsonProperty("spellblock")]
        //public float MagicResist { get; set; }
        //[JsonProperty("spellblockperlevel")]
        //public float MagicResistPerLevel { get; set; }
        //[JsonProperty("attackdamage")]
        //public float AttackDamage { get; set; }
        //[JsonProperty("attackdamageperlevel")]
        //public float AttackDamagePerLevel { get; set; }
        //[JsonProperty("attackspeed")]
        //public float AttackSpeed { get; set; }
        //[JsonProperty("attackspeedperlevel")]
        //public float AttackSpeedPerLevel { get; set; }
        //[JsonProperty("attackrange")]
        //public int AttackRange { get; set; }
        //[JsonProperty("movespeed")]
        //public int MoveSpeed { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}
