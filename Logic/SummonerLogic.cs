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
            // TODO: check if summoner.LastUpdated is not x mins ago, else go ahead with the GetsummonerByName
            Summoner summoner = _iSummonerContext.GetSummonerByName(region, summonerName);
            summoner.LastUpdated = DateTime.Now;
            return summoner;
        }

        // TODO: switch SummonerPlayedGamesList to Summoner.Games somehow:  warning, this gonna be difficult
        public SummonerPlayedGamesList GetSummonerPlayedGames(string region, Summoner summoner)
        {
            SummonerPlayedGamesList summonerPlayedGames = _iSummonerContext.GetSummonerPlayedGames(region, summoner.AccountId);
            // foreach game:
            // summoner = summoner
            // gameinfo = getgameinfo (getgameinfo includes getparticipantsinfo)
            foreach (SummonerPlayedGame summonerPlayedGame in summonerPlayedGames.Matches)
            {
                summonerPlayedGame.Summoner = summoner; // Summoner who we are looking the game up through

                // TODO: If gameId already exists don't look this up through API, will DRASTICALLY decrease number API Calls
                summonerPlayedGame.GameObject = _iSummonerContext.GetPlayedGameInfoFromId(region, summonerPlayedGame.GameId);






                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddMilliseconds(summonerPlayedGame.GameObject.Timestamp).ToLocalTime();
                summonerPlayedGame.GameObject.DateCreated = dtDateTime;

                summonerPlayedGame.GameObject.QueueType = _iSummonerContext.GetQueueTypeInfoFromId(summonerPlayedGame.GameObject.QueueTypeId);
                summonerPlayedGame.ChampionObject = _iSummonerContext.GetChampionInfoFromId(summonerPlayedGame.ChampionId);
                // TODO: Fix so you don't get a Position in games like ARAM
                summonerPlayedGame.Position = _iSummonerContext.GetPositionFromRoleAndLane(summonerPlayedGame.Role, summonerPlayedGame.Lane);
                
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
