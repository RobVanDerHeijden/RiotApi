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
        
        public SummonerPlayedGamesList GetSummonerPlayedGames(string region, string summonerIdAccount)
        {
            SummonerPlayedGamesList summonerPlayedGames = _iSummonerContext.GetSummonerPlayedGames(region, summonerIdAccount);
            foreach (SummonerPlayedGame summonerPlayedGame in summonerPlayedGames.Matches)
            {
                summonerPlayedGame.ChampionObject = _iSummonerContext.GetChampionInfoFromId(summonerPlayedGame.Champion);
            }
            return summonerPlayedGames;
        }

        public List<Rank> GetSummonerRanks(string region, string encryptedSummonerId)
        {
            List<Rank> summonerRanks = _iSummonerContext.GetSummonerRanks(region, encryptedSummonerId);
            // TODO: foreach rank getleaguename with leagueId
            return summonerRanks;
        }
    }
}
