using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private readonly List<Champion> _champions = new List<Champion>()
        {
            new Champion()
            {
                Key = 266,
                ChampionName = "Aatrox"
            },
            new Champion()
            {
                Key = 103,
                ChampionName = "Ahri"
            },
            new Champion()
            {
                Key = 84,
                ChampionName = "Akali"
            },
            new Champion()
            {
                Key = 12,
                ChampionName = "Alistar"
            },
            new Champion()
            {
                Key = 32,
                ChampionName = "Amumu"
            },
            new Champion()
            {
                Key = 34,
                ChampionName = "Anivia"
            },
            new Champion()
            {
                Key = 1,
                ChampionName = "Annie"
            },
            new Champion()
            {
                Key = 22,
                ChampionName = "Ashe"
            },
            new Champion()
            {
                Key = 136,
                ChampionName = "AurelionSol"
            },
            new Champion()
            {
                Key = 268,
                ChampionName = "Azir"
            },
            new Champion()
            {
                Key = 432,
                ChampionName = "Bard"
            },
            new Champion()
            {
                Key = 53,
                ChampionName = "Blitzcrank"
            },
            new Champion()
            {
                Key = 63,
                ChampionName = "Brand"
            },
            new Champion()
            {
                Key = 201,
                ChampionName = "Braum"
            },
            new Champion()
            {
                Key = 51,
                ChampionName = "Caitlyn"
            },
            new Champion()
            {
                Key = 164,
                ChampionName = "Camille"
            },
            new Champion()
            {
                Key = 69,
                ChampionName = "Cassiopeia"
            },
            new Champion()
            {
                Key = 31,
                ChampionName = "Chogath"
            },
            new Champion()
            {
                Key = 42,
                ChampionName = "Corki"
            },
            new Champion()
            {
                Key = 122,
                ChampionName = "Darius"
            },
            new Champion()
            {
                Key = 131,
                ChampionName = "Diana"
            },
            new Champion()
            {
                Key = 119,
                ChampionName = "Draven"
            },
            new Champion()
            {
                Key = 36,
                ChampionName = "DrMundo"
            },
            new Champion()
            {
                Key = 245,
                ChampionName = "Ekko"
            },
            new Champion()
            {
                Key = 60,
                ChampionName = "Elise"
            },
            new Champion()
            {
                Key = 28,
                ChampionName = "Evelynn"
            },
            new Champion()
            {
                Key = 81,
                ChampionName = "Ezreal"
            },
            new Champion()
            {
                Key = 9,
                ChampionName = "Fiddlesticks"
            },
            new Champion()
            {
                Key = 114,
                ChampionName = "Fiora"
            },
            new Champion()
            {
                Key = 105,
                ChampionName = "Fizz"
            },
            new Champion()
            {
                Key = 3,
                ChampionName = "Galio"
            },
            new Champion()
            {
                Key = 41,
                ChampionName = "Gangplank"
            },
            new Champion()
            {
                Key = 86,
                ChampionName = "Garen"
            },
            new Champion()
            {
                Key = 150,
                ChampionName = "Gnar"
            },
            new Champion()
            {
                Key = 79,
                ChampionName = "Gragas"
            },
            new Champion()
            {
                Key = 104,
                ChampionName = "Graves"
            },
            new Champion()
            {
                Key = 120,
                ChampionName = "Hecarim"
            },
            new Champion()
            {
                Key = 74,
                ChampionName = "Heimerdinger"
            },
            new Champion()
            {
                Key = 420,
                ChampionName = "Illaoi"
            },
            new Champion()
            {
                Key = 39,
                ChampionName = "Irelia"
            },
            new Champion()
            {
                Key = 427,
                ChampionName = "Ivern"
            },
            new Champion()
            {
                Key = 40,
                ChampionName = "Janna"
            },
            new Champion()
            {
                Key = 59,
                ChampionName = "JarvanIV"
            },
            new Champion()
            {
                Key = 24,
                ChampionName = "Jax"
            },
            new Champion()
            {
                Key = 126,
                ChampionName = "Jayce"
            },
            new Champion()
            {
                Key = 202,
                ChampionName = "Jhin"
            },
            new Champion()
            {
                Key = 222,
                ChampionName = "Jinx"
            },
            new Champion()
            {
                Key = 145,
                ChampionName = "Kaisa"
            },
            new Champion()
            {
                Key = 429,
                ChampionName = "Kalista"
            },
            new Champion()
            {
                Key = 43,
                ChampionName = "Karma"
            },
            new Champion()
            {
                Key = 30,
                ChampionName = "Karthus"
            },
            new Champion()
            {
                Key = 38,
                ChampionName = "Kassadin"
            },
            new Champion()
            {
                Key = 55,
                ChampionName = "Katarina"
            },
            new Champion()
            {
                Key = 10,
                ChampionName = "Kayle"
            },
            new Champion()
            {
                Key = 141,
                ChampionName = "Kayn"
            },
            new Champion()
            {
                Key = 85,
                ChampionName = "Kennen"
            },
            new Champion()
            {
                Key = 121,
                ChampionName = "Khazix"
            },
            new Champion()
            {
                Key = 203,
                ChampionName = "Kindred"
            },
            new Champion()
            {
                Key = 240,
                ChampionName = "Kled"
            },
            new Champion()
            {
                Key = 96,
                ChampionName = "KogMaw"
            },
            new Champion()
            {
                Key = 7,
                ChampionName = "Leblanc"
            },
            new Champion()
            {
                Key = 64,
                ChampionName = "LeeSin"
            },
            new Champion()
            {
                Key = 89,
                ChampionName = "Leona"
            },
            new Champion()
            {
                Key = 127,
                ChampionName = "Lissandra"
            },
            new Champion()
            {
                Key = 236,
                ChampionName = "Lucian"
            },
            new Champion()
            {
                Key = 117,
                ChampionName = "Lulu"
            },
            new Champion()
            {
                Key = 99,
                ChampionName = "Lux"
            },
            new Champion()
            {
                Key = 54,
                ChampionName = "Malphite"
            },
            new Champion()
            {
                Key = 90,
                ChampionName = "Malzahar"
            },
            new Champion()
            {
                Key = 57,
                ChampionName = "Maokai"
            },
            new Champion()
            {
                Key = 11,
                ChampionName = "MasterYi"
            },
            new Champion()
            {
                Key = 21,
                ChampionName = "MissFortune"
            },
            new Champion()
            {
                Key = 62,
                ChampionName = "MonkeyKing"
            },
            new Champion()
            {
                Key = 82,
                ChampionName = "Mordekaiser"
            },
            new Champion()
            {
                Key = 25,
                ChampionName = "Morgana"
            },
            new Champion()
            {
                Key = 267,
                ChampionName = "Nami"
            },
            new Champion()
            {
                Key = 75,
                ChampionName = "Nasus"
            },
            new Champion()
            {
                Key = 111,
                ChampionName = "Nautilus"
            },
            new Champion()
            {
                Key = 518,
                ChampionName = "Neeko"
            },
            new Champion()
            {
                Key = 76,
                ChampionName = "Nidalee"
            },
            new Champion()
            {
                Key = 56,
                ChampionName = "Nocturne"
            },
            new Champion()
            {
                Key = 20,
                ChampionName = "Nunu"
            },
            new Champion()
            {
                Key = 2,
                ChampionName = "Olaf"
            },
            new Champion()
            {
                Key = 61,
                ChampionName = "Orianna"
            },
            new Champion()
            {
                Key = 516,
                ChampionName = "Ornn"
            },
            new Champion()
            {
                Key = 80,
                ChampionName = "Pantheon"
            },
            new Champion()
            {
                Key = 78,
                ChampionName = "Poppy"
            },
            new Champion()
            {
                Key = 555,
                ChampionName = "Pyke"
            },
            new Champion()
            {
                Key = 246,
                ChampionName = "Qiyana"
            },
            new Champion()
            {
                Key = 133,
                ChampionName = "Quinn"
            },
            new Champion()
            {
                Key = 497,
                ChampionName = "Rakan"
            },
            new Champion()
            {
                Key = 33,
                ChampionName = "Rammus"
            },
            new Champion()
            {
                Key = 421,
                ChampionName = "RekSai"
            },
            new Champion()
            {
                Key = 58,
                ChampionName = "Renekton"
            },
            new Champion()
            {
                Key = 107,
                ChampionName = "Rengar"
            },
            new Champion()
            {
                Key = 92,
                ChampionName = "Riven"
            },
            new Champion()
            {
                Key = 68,
                ChampionName = "Rumble"
            },
            new Champion()
            {
                Key = 13,
                ChampionName = "Ryze"
            },
            new Champion()
            {
                Key = 113,
                ChampionName = "Sejuani"
            },
            new Champion()
            {
                Key = 35,
                ChampionName = "Shaco"
            },
            new Champion()
            {
                Key = 98,
                ChampionName = "Shen"
            },
            new Champion()
            {
                Key = 102,
                ChampionName = "Shyvana"
            },
            new Champion()
            {
                Key = 27,
                ChampionName = "Singed"
            },
            new Champion()
            {
                Key = 14,
                ChampionName = "Sion"
            },
            new Champion()
            {
                Key = 15,
                ChampionName = "Sivir"
            },
            new Champion()
            {
                Key = 72,
                ChampionName = "Skarner"
            },
            new Champion()
            {
                Key = 37,
                ChampionName = "Sona"
            },
            new Champion()
            {
                Key = 16,
                ChampionName = "Soraka"
            },
            new Champion()
            {
                Key = 50,
                ChampionName = "Swain"
            },
            new Champion()
            {
                Key = 517,
                ChampionName = "Sylas"
            },
            new Champion()
            {
                Key = 134,
                ChampionName = "Syndra"
            },
            new Champion()
            {
                Key = 223,
                ChampionName = "TahmKench"
            },
            new Champion()
            {
                Key = 163,
                ChampionName = "Taliyah"
            },
            new Champion()
            {
                Key = 91,
                ChampionName = "Talon"
            },
            new Champion()
            {
                Key = 44,
                ChampionName = "Taric"
            },
            new Champion()
            {
                Key = 17,
                ChampionName = "Teemo"
            },
            new Champion()
            {
                Key = 412,
                ChampionName = "Thresh"
            },
            new Champion()
            {
                Key = 18,
                ChampionName = "Tristana"
            },
            new Champion()
            {
                Key = 48,
                ChampionName = "Trundle"
            },
            new Champion()
            {
                Key = 23,
                ChampionName = "Tryndamere"
            },
            new Champion()
            {
                Key = 4,
                ChampionName = "TwistedFate"
            },
            new Champion()
            {
                Key = 29,
                ChampionName = "Twitch"
            },
            new Champion()
            {
                Key = 77,
                ChampionName = "Udyr"
            },
            new Champion()
            {
                Key = 6,
                ChampionName = "Urgot"
            },
            new Champion()
            {
                Key = 110,
                ChampionName = "Varus"
            },
            new Champion()
            {
                Key = 67,
                ChampionName = "Vayne"
            },
            new Champion()
            {
                Key = 45,
                ChampionName = "Veigar"
            },
            new Champion()
            {
                Key = 161,
                ChampionName = "Velkoz"
            },
            new Champion()
            {
                Key = 254,
                ChampionName = "Vi"
            },
            new Champion()
            {
                Key = 112,
                ChampionName = "Viktor"
            },
            new Champion()
            {
                Key = 8,
                ChampionName = "Vladimir"
            },
            new Champion()
            {
                Key = 106,
                ChampionName = "Volibear"
            },
            new Champion()
            {
                Key = 19,
                ChampionName = "Warwick"
            },
            new Champion()
            {
                Key = 498,
                ChampionName = "Xayah"
            },
            new Champion()
            {
                Key = 101,
                ChampionName = "Xerath"
            },
            new Champion()
            {
                Key = 5,
                ChampionName = "XinZhao"
            },
            new Champion()
            {
                Key = 157,
                ChampionName = "Yasuo"
            },
            new Champion()
            {
                Key = 83,
                ChampionName = "Yorick"
            },
            new Champion()
            {
                Key = 350,
                ChampionName = "Yuumi"
            },
            new Champion()
            {
                Key = 154,
                ChampionName = "Zac"
            },
            new Champion()
            {
                Key = 238,
                ChampionName = "Zed"
            },
            new Champion()
            {
                Key = 115,
                ChampionName = "Ziggs"
            },
            new Champion()
            {
                Key = 26,
                ChampionName = "Zilean"
            },
            new Champion()
            {
                Key = 142,
                ChampionName = "Zoe"
            },
            new Champion()
            {
                Key = 143,
                ChampionName = "Zyra"
            }
        };

        private readonly string _APIFilePath = "API/APIKey.txt";

        public List<string> GetRegions()
        {
            return _regions;
        }

        // API Section Start
        public Summoner GetSummonerByName(string region, string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;

            HttpResponseMessage response = GetHttpResponse(GetCombinedURI(region, path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Summoner>(content);
            }

            return null;
        }

        public SummonerPlayedGameList GetSummonerPlayedGames(string region, string summonerIdAccount)
        {
            string path = "match/v4/matchlists/by-account/" + summonerIdAccount;

            // TODO: Remove + "&endIndex=3". Only for testing small sample
            HttpResponseMessage response = GetHttpResponse(GetCombinedURI(region, path) + "&endIndex=3");
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerPlayedGameList>(content);
            }

            return null;
        }

        public Champion GetChampionInfoFromId(int championId)
        {
            Champion champion = _champions.First(item => item.Key == championId);

            if (champion == null)
            {
                throw new Exception();
            }
                
            return champion;
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
            StreamReader sr = new StreamReader(_APIFilePath);
            return sr.ReadToEnd();
        }
        protected string GetCombinedURI(string region, string path)
        {
            return "https://" + region + ".api.riotgames.com/lol/" + path + "?api_key=" + GetAPIKey();
        }
    }
}
