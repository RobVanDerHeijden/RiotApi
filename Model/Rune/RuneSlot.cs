using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    public class RuneSlot
    {
        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }
    }
}
