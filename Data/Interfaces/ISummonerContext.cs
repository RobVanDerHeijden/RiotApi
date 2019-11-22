using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Data.Interfaces
{
    public interface ISummonerContext
    {
        List<string> GetRegions();

        // Get Summoner
        Summoner GetSummonerByName(string region, string summonerName);

        // Get Games
        SummonerPlayedGamesList GetSummonerPlayedGames(string region, string summonerIdAccount);
        PlayedGame GetPlayedGameInfoFromId(string region, long gameId);
        
        // Get Ranks
        List<Rank> GetSummonerRanks(string region, string encryptedSummonerId);

        // General
        Champion GetChampionInfoFromId(int championId);
        SummonerSpell GetSummonerSpellInfoFromId(int summonerSpellId);
        Item GetItemInfoFromId(int itemId);
        Position GetPositionFromRoleAndLane(string role, string lane);
        QueueType GetQueueTypeInfoFromId(int queueTypeId);
    }
}
