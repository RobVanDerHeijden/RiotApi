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
            Summoner summoner = new Summoner();

            summoner = _iSummonerContext.GetSummonerByName(region, summonerName);

            return summoner;
        }



        //public List<SummonerPlayedGame> GetSummonerPlayedGames()
        //{

        //}
    }
}
