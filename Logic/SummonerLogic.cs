﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Contexts.Memory;
using Data.Interfaces;
using Data.Repositorys;
using Model;

namespace Logic
{
    public class SummonerLogic
    {
        private readonly ISummonerSQLContext _iSummonerContext = new SummonerSQLMemoryContext();
        private readonly SummonerRepo _summonerRepo = new SummonerRepo();

        //public SummonerLogic(ISummonerSQLContext summonerContext, SummonerRepo summonerRepo)
        //{
        //    _iSummonerContext = summonerContext;
        //    _summonerRepo = summonerRepo;
        //}
        //public SummonerLogic(SummonerRepo summonerRepo)
        //{
        //    _summonerRepo = summonerRepo;
        //}
        public SummonerLogic()
        {
           
        }

        public List<string> GetRegions()
        {
            return _summonerRepo.GetRegions();
        }
        public Summoner GetSummonerByName(string region, string summonerName)
        {
            // TODO: check if summoner.LastUpdated is not x mins ago, else go ahead with the GetsummonerByName
            Summoner summoner = _iSummonerContext.GetSummonerByName(region, summonerName);
            summoner.LastUpdated = DateTime.Now;
            summoner.Region = region;
            return summoner;
        }
        
        public SummonerPlayedGamesList GetSummonerPlayedGames(string region, Summoner summoner)
        {
            SummonerPlayedGamesList summonerPlayedGames = new SummonerPlayedGamesList();
            if (_iSummonerContext.GetSummonerPlayedGames(region, summoner.AccountId) != null)
            {
                summonerPlayedGames = _iSummonerContext.GetSummonerPlayedGames(region, summoner.AccountId);
                summonerPlayedGames.Summoner = summoner;            
            
                // foreach game:
                // gameinfo = getgameinfo (getgameinfo includes getparticipantsinfo)
                // TODO: Find a cleaner solution to fill this object variables, I mean there has te be one, right?
                // Perhaps a List<int> GameIds -> then foreach in GameIds
                foreach (PlayedGame playedGame in summonerPlayedGames.Matches)
                {
                    // TODO: If gameId already exists don't look this up through API, will DRASTICALLY decrease number API Calls
                    PlayedGame tempPlayedGameObject = _iSummonerContext.GetPlayedGameInfoFromId(region, playedGame.GameId);
                    
                    playedGame.Season = tempPlayedGameObject.Season;
                    playedGame.Duration = tempPlayedGameObject.Duration;
                    playedGame.ParticipantIdentities = tempPlayedGameObject.ParticipantIdentities;
                    playedGame.Participants = tempPlayedGameObject.Participants;
                    playedGame.PlayedGameTeams = tempPlayedGameObject.PlayedGameTeams;
                    playedGame.QueueTypeId = tempPlayedGameObject.QueueTypeId;
                    playedGame.Timestamp = tempPlayedGameObject.Timestamp;

                    DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                    dtDateTime = dtDateTime.AddMilliseconds(playedGame.Timestamp).ToLocalTime();
                    playedGame.DateCreated = dtDateTime;

                    playedGame.QueueType = _iSummonerContext.GetQueueTypeInfoFromId(playedGame.QueueTypeId);
                    
                    
                    foreach (PlayedGameTeam playedGameTeam in playedGame.PlayedGameTeams)
                    {
                        playedGameTeam.PlayedGamePlayers = new List<SummonerPlayedGame>();
                        foreach (var ban in playedGameTeam.Bans)
                        {
                            ban.ChampionObject = _iSummonerContext.GetChampionInfoFromId(ban.ChampionId);
                        }
                        foreach (var participant in playedGame.Participants.Where(n => n.TeamId == playedGameTeam.TeamId))
                        {
                            var playerIdentity = playedGame.ParticipantIdentities.Single(s => s.ParticipantId == participant.ParticipantId);
                            var playerName = playerIdentity.Player.SummonerName;

                            SummonerPlayedGame newPlayer = new SummonerPlayedGame()
                            {
                                SummonerName = playerName,
                                //Summoner = GetSummonerByName(region, playerName), // This Works, but might not be worth all the extra API Calls
                                ChampionId = participant.ChampionId,
                                SummonerSpell1Id = participant.Spell1Id,
                                SummonerSpell2Id = participant.Spell2Id,
                                

                                // TODO: Fix so you don't get a Position in games like ARAM
                                Position = _iSummonerContext.GetPositionFromRoleAndLane(participant.Timeline.Role, participant.Timeline.Lane),

                                ChampionObject = _iSummonerContext.GetChampionInfoFromId(participant.ChampionId),
                                
                                // TODO: Add the rest of the variables, or find better solution for this
                                PlayerStats = participant.Stats
                            };
                            if (newPlayer.SummonerSpell1Id != 0 && newPlayer.SummonerSpell2Id != 0)
                            {
                                newPlayer.SummonerSpell1Object = _iSummonerContext.GetSummonerSpellInfoFromId(participant.Spell1Id);
                                newPlayer.SummonerSpell2Object = _iSummonerContext.GetSummonerSpellInfoFromId(participant.Spell2Id);
                            }

                            newPlayer.PlayerStats.ItemList = new List<Item>
                            {
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item0),
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item1),
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item2),
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item3),
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item4),
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item5),
                                _iSummonerContext.GetItemInfoFromId(participant.Stats.Item6)
                            };
                            newPlayer.PlayerStats.PrimaryRunePath = _iSummonerContext.GetRunePathInfoFromId(participant.Stats.PerkPrimaryStyle);
                            newPlayer.PlayerStats.SecondaryRunePath = _iSummonerContext.GetRunePathInfoFromId(participant.Stats.PerkSubStyle);

                            playedGameTeam.PlayedGamePlayers.Add(newPlayer);
                        }
                    }
                }
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
