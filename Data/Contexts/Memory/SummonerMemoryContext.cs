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
        private static readonly List<Map> _maps = new List<Map>()
        {
            new Map()
            {
                IdMap = 1,
                Name = "Summoner's Rift",
                Notes = "Original Summer variant"
            },
            new Map()
            {
                IdMap = 2,
                Name = "Summoner's Rift",
                Notes = "Original Autumn variant"
            },new Map()
            {
                IdMap = 3,
                Name = "The Proving Grounds",
                Notes = "Tutorial Map"
            },new Map()
            {
                IdMap = 4,
                Name = "Twisted Treeline",
                Notes = "Original Version"
            },new Map()
            {
                IdMap = 8,
                Name = "The Crystal Scar",
                Notes = "Dominion map"
            },new Map()
            {
                IdMap = 10,
                Name = "Twisted Treeline",
                Notes = "Last TT map"
            },new Map()
            {
                IdMap = 11,
                Name = "Summoner's Rift",
                Notes = "Current Version"
            },new Map()
            {
                IdMap = 12,
                Name = "Howling Abyss",
                Notes = "ARAM map"
            },new Map()
            {
                IdMap = 14,
                Name = "Butcher's Bridge",
                Notes = "Alternate ARAM map"
            },new Map()
            {
                IdMap = 16,
                Name = "Cosmic Ruins",
                Notes = "Dark Star: Singularity map"
            },new Map()
            {
                IdMap = 18,
                Name = "Valoran City Park",
                Notes = "Star Guardian Invasion map"
            },new Map()
            {
                IdMap = 19,
                Name = "Substructure 43",
                Notes = "PROJECT: Hunters map"
            },new Map()
            {
                IdMap = 20,
                Name = "Crash Site",
                Notes = "Odyssey: Extraction map"
            },new Map()
            {
                IdMap = 21,
                Name = "Nexus Blitz",
                Notes = "Nexus Blitz map"
            },
        };
        private readonly List<QueueType> _queueTypes = new List<QueueType>()
        {
            // TODO: Add DisplayNames for the Queues in use
            new QueueType()
            {
                IdQueue = 0,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Custom games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 2,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Blind Pick games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 430"
            },
            new QueueType()
            {
                IdQueue = 4,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Ranked Solo games",
                Notes = "Deprecated in favor of queueId 420"
            },
            new QueueType()
            {
                IdQueue = 6,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Ranked Premade games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 7,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs AI games",
                Notes = "Deprecated in favor of queueId 32 and 33"
            },
            new QueueType()
            {
                IdQueue = 8,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "3v3 Normal games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 460"
            },
            new QueueType()
            {
                IdQueue = 9,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "3v3 Ranked Flex games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 470"
            },
            new QueueType()
            {
                IdQueue = 14,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Draft Pick games",
                Notes = "Deprecated in favor of queueId 400"
            },
            new QueueType()
            {
                IdQueue = 16,
                Map = _maps.First(item => item.IdMap == 8),
                Description = "5v5 Dominion Blind Pick games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 17,
                Map = _maps.First(item => item.IdMap == 8),
                Description = "5v5 Dominion Draft Pick games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 25,
                Map = _maps.First(item => item.IdMap == 8),
                Description = "Dominion Co-op vs AI games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 31,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs AI Intro Bot games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 830"
            },
            new QueueType()
            {
                IdQueue = 32,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs AI Beginner Bot games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 840"
            },
            new QueueType()
            {
                IdQueue = 33,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs AI Intermediate Bot games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 850"
            },
            new QueueType()
            {
                IdQueue = 41,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "3v3 Ranked Team games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 42,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Ranked Team games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 52,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "Co-op vs AI games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 800"
            },
            new QueueType()
            {
                IdQueue = 61,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Team Builder games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 65,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "5v5 ARAM games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 450"
            },
            new QueueType()
            {
                IdQueue = 67,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "ARAM Co-op vs AI games",
                Notes = "Game mode deprecated"
            },
            new QueueType()
            {
                IdQueue = 70,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "One for All games",
                Notes = "Deprecated in patch 8.6 in favor of queueId 1020"
            },
            new QueueType()
            {
                IdQueue = 72,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "1v1 Snowdown Showdown games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 73,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "2v2 Snowdown Showdown games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 75,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "6v6 Hexakill games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 76,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Ultra Rapid Fire games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 78,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "One For All: Mirror Mode games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 83,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs AI Ultra Rapid Fire games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 91,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Doom Bots Rank 1 games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 950"
            },
            new QueueType()
            {
                IdQueue = 92,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Doom Bots Rank 2 games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 950"
            },
            new QueueType()
            {
                IdQueue = 93,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Doom Bots Rank 5 games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 950"
            },
            new QueueType()
            {
                IdQueue = 96,
                Map = _maps.First(item => item.IdMap == 8),
                Description = "Ascension games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 910"
            },
            new QueueType()
            {
                IdQueue = 98,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "6v6 Hexakill games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 100,
                Map = _maps.First(item => item.IdMap == 14),
                Description = "5v5 ARAM games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 300,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "Legend of the Poro King games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 920"
            },
            new QueueType()
            {
                IdQueue = 310,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Nemesis games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 313,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Black Market Brawlers games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 315,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Nexus Siege games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 940"
            },
            new QueueType()
            {
                IdQueue = 317,
                Map = _maps.First(item => item.IdMap == 8),
                Description = "Definitely Not Dominion games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 318,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "ARURF games",
                Notes = "Deprecated in patch 7.19 in favor of queueId 900"
            },
            new QueueType()
            {
                IdQueue = 325,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "All Random games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 400,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Draft Pick games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 410,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Ranked Dynamic games",
                Notes = "Game mode deprecated in patch 6.22"
            },
            new QueueType()
            {
                IdQueue = 420,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Ranked Solo games",
                Notes = "",
                DisplayName = "Ranked Solo 5v5"

            },
            new QueueType()
            {
                IdQueue = 430,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Blind Pick games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 440,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "5v5 Ranked Flex games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 450,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "5v5 ARAM games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 460,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "3v3 Blind Pick games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 470,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "3v3 Ranked Flex games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 600,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Blood Hunt Assassin games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 610,
                Map = _maps.First(item => item.IdMap == 16),
                Description = "Dark Star: Singularity games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 700,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Clash games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 800,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "Co-op vs. AI Intermediate Bot games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 810,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "Co-op vs. AI Intro Bot games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 820,
                Map = _maps.First(item => item.IdMap == 10),
                Description = "Co-op vs. AI Beginner Bot games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 830,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs. AI Intro Bot games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 840,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs. AI Beginner Bot games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 850,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Co-op vs. AI Intermediate Bot games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 900,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "URF games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 910,
                Map = _maps.First(item => item.IdMap == 8),
                Description = "Ascension games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 920,
                Map = _maps.First(item => item.IdMap == 12),
                Description = "Legend of the Poro King games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 940,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Nexus Siege games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 950,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Doom Bots Voting games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 960,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Doom Bots Standard games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 980,
                Map = _maps.First(item => item.IdMap == 18),
                Description = "Star Guardian Invasion: Normal games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 990,
                Map = _maps.First(item => item.IdMap == 18),
                Description = "Star Guardian Invasion: Onslaught games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1000,
                Map = _maps.First(item => item.IdMap == 19), // Overcharge
                Description = "PROJECT: Hunters games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1010,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "Snow ARURF games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1020,
                Map = _maps.First(item => item.IdMap == 11),
                Description = "One for All games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1030,
                Map = _maps.First(item => item.IdMap == 20),
                Description = "Odyssey Extraction: Intro games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1040,
                Map = _maps.First(item => item.IdMap == 20),
                Description = "Odyssey Extraction: Cadet games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1050,
                Map = _maps.First(item => item.IdMap == 20),
                Description = "Odyssey Extraction: Crewmember games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1060,
                Map = _maps.First(item => item.IdMap == 20),
                Description = "Odyssey Extraction: Captain games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1070,
                Map = _maps.First(item => item.IdMap == 20),
                Description = "Odyssey Extraction: Onslaught games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1090,
                Map = _maps.First(item => item.IdMap == 11), // Convergence
                Description = "Teamfight Tactics games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1100,
                Map = _maps.First(item => item.IdMap == 11), // Convergence
                Description = "Ranked Teamfight Tactics games",
                Notes = ""
            },
            new QueueType()
            {
                IdQueue = 1200,
                Map = _maps.First(item => item.IdMap == 21),
                Description = "Nexus Blitz games",
                Notes = "Deprecated in patch 9.2"
            }
        };
        private readonly List<Position> _positions = new List<Position>()
        {
            /*  Role:   SOLO    NONE    SOLO      DUO_CARRY   DUO_SUPPORT
             *  Lane:   TOP     JUNGLE  MIDDLE    BOTTOM      BOTTOM
             */
            new Position()
            {
                Name = "NONE",
            },
            new Position()
            {
                Name = "Top",
                Role = "SOLO",
                Lane = "TOP"
            },
            new Position()
            {
                Name = "Jungle",
                Role = "NONE",
                Lane = "JUNGLE"
            },
            new Position()
            {
                Name = "Mid",
                Role = "SOLO",
                Lane = "MIDDLE"
            },
            new Position()
            {
                Name = "Bottom",
                Role = "DUO_CARRY",
                Lane = "BOTTOM"
            },
            new Position()
            {
                Name = "Support",
                Role = "DUO_SUPPORT",
                Lane = "BOTTOM"
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

        public SummonerPlayedGamesList GetSummonerPlayedGames(string region, string summonerIdAccount)
        {
            string path = "match/v4/matchlists/by-account/" + summonerIdAccount;

            // TODO: Remove + "&endIndex=5". Only for testing smaller sample
            HttpResponseMessage response = GetHttpResponse(GetCombinedURI(region, path) + "&endIndex=5");
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerPlayedGamesList>(content);
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
        public PlayedGame GetPlayedGameInfoFromId(string region, long gameId)
        {
            string path = "match/v4/matches/" + gameId;

            HttpResponseMessage response = GetHttpResponse(GetCombinedURI(region, path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<PlayedGame>(content);
            }

            return null;
        }
        public Position GetPositionFromRoleAndLane(string role, string lane)
        {
            return _positions.Find(p => p.Role == role && p.Lane == lane);
        }

        public QueueType GetQueueTypeInfoFromId(int queueTypeId)
        {
            return _queueTypes.Find(q => q.IdQueue == queueTypeId);
        }

        public List<Rank> GetSummonerRanks(string region, string encryptedSummonerId)
        {
            string path = "league/v4/entries/by-summoner/" + encryptedSummonerId;
            
            HttpResponseMessage response = GetHttpResponse(GetCombinedURI(region, path));
            string content = response.Content.ReadAsStringAsync().Result;
            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<Rank>>(content);
            }

            return null;
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
