using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Data.Interfaces
{
    public interface ISummonerAPIContext
    {
        // Get Summoner
        Summoner GetSummonerByName(string region, string summonerName);
    }
}
