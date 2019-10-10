using System;
using System.Collections.Generic;
using System.Text;
using RiotApi.API;

namespace RiotApi.Controller
{
    public class ControllerMain
    {
        public bool DoesSummonerExist(string region, string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            return summoner != null;
        }

        public List<string> GetRegions()
        {
            List<string> regionEndPoints = new List<string>()
            {
                "BR1",
                "EUN1",
                "EUW1",
                "JP1",
                "KR",
                "LA1",
                "LA2",
                "NA1",
                "OC1",
                "TR1",
                "RU",
                "PBE1"
            };
            return regionEndPoints;
            //Dictionary<string, string> regionEndPointsNew = new Dictionary<string, string>();

            //regionEndPointsNew.Add("BR1", "BR");
            //regionEndPointsNew.Add("EUN1", "EUNE");
            //regionEndPointsNew.Add("EUW1", "EUW");
            //regionEndPointsNew.Add("JP1", "JP");
            //regionEndPointsNew.Add("KR", "KR");
            //regionEndPointsNew.Add("LA1", "LAN");
            //regionEndPointsNew.Add("LA2", "LAS");
            //regionEndPointsNew.Add("NA1", "NA");
            //regionEndPointsNew.Add("OC1", "OCE");
            //regionEndPointsNew.Add("TR1", "TR");
            //regionEndPointsNew.Add("RU", "RU");
            //regionEndPointsNew.Add("PBE1", "PBE");
            //return regionEndPointsNew;
        }
    }
}
