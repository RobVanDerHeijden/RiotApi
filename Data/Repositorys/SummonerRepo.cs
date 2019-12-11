using System;
using System.Collections.Generic;
using System.Text;
using Data.Contexts.API;
using Data.Contexts.SQL;
using Data.Interfaces;

namespace Data.Repositorys
{
    public class SummonerRepo
    {

        private readonly ISummonerSQLContext _isummonerSQLContext;
        private readonly ISummonerAPIContext _isummonerAPIContext;

        public SummonerRepo()
        {
            _isummonerSQLContext = new SummonerSQLContext();
            _isummonerAPIContext = new SummonerAPIContext();
        }

        public List<string> GetRegions()
        {
            return _isummonerSQLContext.GetRegions();
        }


    }
}
