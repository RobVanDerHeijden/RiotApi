using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RiotApi.Model;

namespace RiotApi.API
{
    public class Summoner_V4 : API
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public SummonerDTO GetSummonerByName(string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
