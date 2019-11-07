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
        
        public SummonerPlayedGamesList GetSummonerPlayedGames(string region, Summoner summoner)
        {
            SummonerPlayedGamesList summonerPlayedGames = _iSummonerContext.GetSummonerPlayedGames(region, summoner.AccountId);
            // foreach game:
            // gameinfo = getgameinfo (getgameinfo includes getparticipantsinfo)
            // TODO: Find a cleaner solution to fill this object variables, I mean there has te be one right?
            // Perhaps a List<int> GameIds -> then foreach in GameIds
            foreach (PlayedGame summonerPlayedGame in summonerPlayedGames.Matches)
            {
                //summonerPlayedGame.Summoner = summoner; // Summoner who we are looking the game up through

                // TODO: If gameId already exists don't look this up through API, will DRASTICALLY decrease number API Calls
                PlayedGame tempPlayedGameObject = _iSummonerContext.GetPlayedGameInfoFromId(region, summonerPlayedGame.GameId);
                
                //summonerPlayedGame.ChampionObject = _iSummonerContext.GetChampionInfoFromId(summonerPlayedGame.ChampionId);
                // TODO: Fix so you don't get a Position in games like ARAM
                //summonerPlayedGame.Position = _iSummonerContext.GetPositionFromRoleAndLane(summonerPlayedGame.Role, summonerPlayedGame.Lane);
                summonerPlayedGame.Season = tempPlayedGameObject.Season;
                summonerPlayedGame.Duration = tempPlayedGameObject.Duration;
                summonerPlayedGame.ParticipantIdentities = tempPlayedGameObject.ParticipantIdentities;
                summonerPlayedGame.Participants = tempPlayedGameObject.Participants;
                summonerPlayedGame.PlayedGameTeams = tempPlayedGameObject.PlayedGameTeams;
                summonerPlayedGame.QueueTypeId = tempPlayedGameObject.QueueTypeId;
                summonerPlayedGame.Timestamp = tempPlayedGameObject.Timestamp;

                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddMilliseconds(summonerPlayedGame.Timestamp).ToLocalTime();
                summonerPlayedGame.DateCreated = dtDateTime;

                summonerPlayedGame.QueueType = _iSummonerContext.GetQueueTypeInfoFromId(summonerPlayedGame.QueueTypeId);

                //foreach (PlayedGameTeam playedGameTeam in summonerPlayedGame.PlayedGameTeams)
                //{
                //    playedGameTeam.PlayedGamePlayers = 
                //}
            }
            return summonerPlayedGames;
        }

        public List<PlayedGame> GetSummonerPlayedGames2(string region, Summoner summoner)
        {

            SummonerPlayedGamesList summonerPlayedGames =  _iSummonerContext.GetSummonerPlayedGames(region, summoner.AccountId);
            //List<PlayedGame> playedGames = summonerPlayedGames.Matches;
            return null;
        }

        public List<Rank> GetSummonerRanks(string region, string encryptedSummonerId)
        {
            List<Rank> summonerRanks = _iSummonerContext.GetSummonerRanks(region, encryptedSummonerId);
            // TODO: foreach rank getleaguename with leagueId
            return summonerRanks;
        }


    }
}
