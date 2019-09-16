using System;
using System.Collections.Generic;
using System.Text;
using RiotApi.API;

namespace RiotApi.Controller
{
    public class ControllerMain
    {
        public bool GetSummoner(string region, string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            return summoner != null;
        }
    }
}
