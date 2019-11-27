using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Model;

namespace WebApp.Models
{
    public class SummonerViewModel
    {
        [Required(ErrorMessage = "Fill in SummonerName!")]
        public string SummonerName { get; set; }

        [Required(ErrorMessage = "Fill in Region!")]
        public string Region { get; set; }

        public Summoner Summoner { get; set; }

        public List<PlayedGame> SummonerPlayedGames { get; set; }

        public List<Rank> SummonerRanks { get; set; }

        public List<string> RegionList { get; set; }
    }
}
