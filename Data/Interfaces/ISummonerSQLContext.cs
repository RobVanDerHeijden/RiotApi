using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Data.Interfaces
{
    public interface ISummonerSQLContext
    {
        // Summoner
        Summoner GetSummonerByName(string region, string summonerName);
        void SaveNewSummoner(Summoner summoner);
        void UpdateSummoner(Summoner summoner);

        // Get Games
        SummonerPlayedGamesList GetSummonerPlayedGames(string region, string summonerIdAccount);
        PlayedGame GetPlayedGameInfoFromId(string region, long gameId);
        
        // Get Ranks
        List<Rank> GetSummonerRanks(string region, string encryptedSummonerId);

        // General
        List<string> GetRegions();
        Champion GetChampionInfoFromId(int championId);
        SummonerSpell GetSummonerSpellInfoFromId(int summonerSpellId);
        Item GetItemInfoFromId(int itemId);
        RunePath GetRunePathInfoFromId(int runePathId);
        QueueType GetQueueTypeInfoFromId(int queueTypeId);

        Position GetPositionFromRoleAndLane(string role, string lane);
        
    }
}
