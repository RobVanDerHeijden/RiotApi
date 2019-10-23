using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Data.Interfaces
{
    public interface ISummonerContext
    {
        List<string> GetRegions();
        Summoner GetSummonerByName(string region, string summonerName);
        SummonerPlayedGamesList GetSummonerPlayedGames(string region, string summonerIdAccount);
        Champion GetChampionInfoFromId(int championId);
        List<Rank> GetSummonerRanks(string region, string encryptedSummonerId);
    }
}
