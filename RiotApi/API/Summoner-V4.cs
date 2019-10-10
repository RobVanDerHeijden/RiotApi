using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Newtonsoft.Json;
using RiotApi.Model;

namespace RiotApi.API
{
    public class Summoner_V4 : API
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public Summoner GetSummonerByName(string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;

            var response = GetHttpResponse(GetCombinedURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Summoner>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
