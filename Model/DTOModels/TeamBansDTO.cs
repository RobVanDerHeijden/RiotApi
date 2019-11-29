using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Newtonsoft.Json;

namespace RiotApi.Model
{
    public class TeamBansDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        public Champion ChampionObject { get; set; }
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
    }
}
