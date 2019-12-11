using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Data.Interfaces;
using Model;
using Newtonsoft.Json;

namespace Data.Contexts.API
{
    public class SummonerAPIContext : ISummonerAPIContext
    {

        private readonly string _APIFilePath = "API/APIKey.txt";

        public Summoner GetSummonerByName(string region, string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;

            HttpResponseMessage response = GetHttpResponse(GetCombinedURI(region, path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Summoner>(content);
            }
            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                return new Summoner()
                {
                    Name = "API_KEY_INVALLID"
                };
            }
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new Summoner()
                {
                    Name = "SUMMONER_NOT_FOUND"
                };
            }

            return null;
        }




        // API Helpers
        protected HttpResponseMessage GetHttpResponse(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }
        protected string GetAPIKey()
        {
            StreamReader sr = new StreamReader(_APIFilePath);
            return sr.ReadToEnd();
        }
        protected string GetCombinedURI(string region, string path)
        {
            return "https://" + region + ".api.riotgames.com/lol/" + path + "?api_key=" + GetAPIKey();
        }


    }
}
