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
        Champion GetChampionInfoFromId(int championId);
        PlayedGame GetPlayedGameInfoFromId(string region, long gameId);
        Position GetPositionFromRoleAndLane(string role, string lane);

        // Get Ranks
        List<Rank> GetSummonerRanks(string region, string encryptedSummonerId);
        
    }
}
