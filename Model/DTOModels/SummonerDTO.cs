﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class SummonerDTO
    {
        public int ProfileIconId { get; set; }
        public string Name { get; set; }
        //public string Puuid { get; set; }
        public long SummonerLevel { get; set; }
        public long RevisionDate { get; set; }

        public string Id { get; set; }
        public string AccountId { get; set; }
    }
}
