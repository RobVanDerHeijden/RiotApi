using System;
using System.Collections.Generic;
using System.Text;
using Data.Interfaces;
using Model;

namespace Logic
{
    public class SummonerLogic
    {
        private readonly ISummonerContext _iSummonerContext;

        public SummonerLogic(ISummonerContext summonerContext)
        {
            _iSummonerContext = summonerContext;
        }

        public List<string> GetRegions()
        {
            return _iSummonerContext.GetRegions();
        }
        public Summoner GetSummonerByName(string region, string summonerName)
        {
            Summoner summoner = _iSummonerContext.GetSummonerByName(region, summonerName);
            return summoner;
        }
        
        public SummonerPlayedGameList GetSummonerPlayedGames(string region, string summonerIdAccount)
        {
            SummonerPlayedGameList summonerPlayedGames = _iSummonerContext.GetSummonerPlayedGames(region, summonerIdAccount);
            foreach (SummonerPlayedGame summonerPlayedGame in summonerPlayedGames.Matches)
            {
                
                summonerPlayedGame.ChampionReal = _iSummonerContext.GetChampionInfoFromId(summonerPlayedGame.Champion);
            }
            return summonerPlayedGames;
        }
    }
}
