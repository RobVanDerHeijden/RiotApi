using System.Collections.Generic;
using System.Diagnostics;
using Data.Interfaces;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly SummonerLogic _summonerLogic;

        // TODO: Add routes
        // TODO: Add viewmodels

        public HomeController(ISummonerSQLContext summonerContext)
        {
            _summonerLogic = new SummonerLogic(summonerContext);
        }

        public IActionResult Index()
        {
            ViewBag.RegionList = _summonerLogic.GetRegions();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SummonerViewModel summonerViewModel)
        {
            // API CALL #1
            Summoner summoner = _summonerLogic.GetSummonerByName(summonerViewModel.Region, summonerViewModel.Id);
            if (summoner == null)
            {
                // TODO: Make this a redirect? to a summoner not found page perhaps
                TempData["SummonerName"] = "SUMMONER NOT FOUND";
            }
            else
            {
                summonerViewModel.Summoner = summoner;
                ViewBag.Summoner = summoner;

                // API CALL #2 + 1 Per Match
                SummonerPlayedGamesList summonerPlayedGames = _summonerLogic.GetSummonerPlayedGames(summonerViewModel.Region, summoner);
                summonerViewModel.SummonerPlayedGames = summonerPlayedGames.Matches;
                ViewBag.PlayedGames = summonerPlayedGames.Matches;

                // API CALL #3
                List<Rank> summonerRanks = _summonerLogic.GetSummonerRanks(summonerViewModel.Region, summoner.SummonerId);
                summonerViewModel.SummonerRanks = summonerRanks;
                ViewBag.SummonerRanks = summonerRanks;
                // API CALL tbd
                // TODO: get the leaguename from each rank

                // API CALLSSS tbd
                // TODO: get the summoner-champions + mastery(MASTERY IS SEPERATE CALL) + winrate and KDA (FIGURE OUT HOW I WANT TO CALCULATE THIS)
            }

            summonerViewModel.RegionList = _summonerLogic.GetRegions();
            ViewBag.RegionList = _summonerLogic.GetRegions();


            return View(summonerViewModel);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
