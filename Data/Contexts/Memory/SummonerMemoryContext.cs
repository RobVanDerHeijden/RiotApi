using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Data.Interfaces;
using Model;
using Newtonsoft.Json;

namespace Data.Contexts.Memory
{
    public class SummonerMemoryContext : ISummonerContext
    {
        private readonly List<string> _regions = new List<string>()
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
        /* example players
        private List<string> _regionsxx = new List<string>
        {
            new Region
            {
                PlayerId = 1,
                Username = "UnitPLayer",
                Password = "1234",
                Role = "player",
                PlayerLevel = 0,
                Experience = 0,
                SkillPoints = 5,
                Money = 100,
                Income = 1,
                Energy = 100,
                EnergyRegen = 5,
                RefillableEnergy = 100,
                LastTimeEnergyRefilled = DateTime.Now,
                MaxEnergy = 100,
                RealName = "Unit Player",
                Country = "Netherlands",
                City = "Eindhoven"
            },
            new Player
            {
                PlayerId = 2,
                Username = "UnitPLayer2",
                Password = "1234",
                Role = "player",
                PlayerLevel = 0,
                Experience = 0,
                SkillPoints = 5,
                Money = 100,
                Income = 1,
                Energy = 100,
                EnergyRegen = 5,
                RefillableEnergy = 100,
                LastTimeEnergyRefilled = DateTime.Now,
                MaxEnergy = 100,
                RealName = "Unit Player 2",
                Country = "Netherlands",
                City = "Eindhoven"
            },
            new Player
            {
                PlayerId = 3,
                Username = "UnitPLayer3",
                Password = "1234",
                Role = "player",
                PlayerLevel = 0,
                Experience = 0,
                SkillPoints = 5,
                Money = 100,
                Income = 1,
                Energy = 100,
                EnergyRegen = 5,
                RefillableEnergy = 100,
                LastTimeEnergyRefilled = DateTime.Now,
                MaxEnergy = 100,
                RealName = "Unit Player 3",
                Country = "Netherlands",
                City = "Eindhoven"
            }
        };
        */

        public List<string> GetRegions()
        {
            return _regions;
        }

        //public bool GetSummonerByName(string region, string summonerName)
        //{
        //    throw new NotImplementedException();
        //}

        // API Section Start
        public Summoner GetSummonerByName(string region, string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;

            var response = GetHttpResponse(GetCombinedURI(region, path));
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
            StreamReader sr = new StreamReader("API/APIKey.txt");
            return sr.ReadToEnd();
        }
        protected string GetCombinedURI(string region, string path)
        {
            return "https://" + region + ".api.riotgames.com/lol/" + path + "?api_key=" + GetAPIKey();
        }
        

    }
}
