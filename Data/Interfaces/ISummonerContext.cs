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
    }
}
