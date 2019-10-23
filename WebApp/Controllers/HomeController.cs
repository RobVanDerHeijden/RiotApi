﻿using System.Collections.Generic;
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

        public HomeController(ISummonerContext summonerContext)
        {
            _summonerLogic = new SummonerLogic(summonerContext);
        }

        public IActionResult Index()
        {
            List<string> regions = _summonerLogic.GetRegions();
            ViewBag.RegionList = regions;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ViewModelMain summonerViewModel)
        {
            // TODO: Add if summoner is null, test by using incorrect API key
            Summoner summoner = _summonerLogic.GetSummonerByName(summonerViewModel.Region, summonerViewModel.SummonerName);

            TempData["SummonerName"] = summoner.Name;
            TempData["SummonerLevel"] = summoner.SummonerLevel;
            TempData["ProfileIconId"] = summoner.ProfileIconId;
            TempData["RevisionDate"] = summoner.RevisionDateLong;
            SummonerPlayedGamesList summonerPlayedGameses = _summonerLogic.GetSummonerPlayedGames(summonerViewModel.Region, summoner.AccountId);
            ViewBag.PlayedGames = summonerPlayedGameses.Matches;

            // TODO: Rank(s) from summoner
            List<Rank> summonerRanks = _summonerLogic.GetSummonerRanks(summonerViewModel.Region, summoner.EncryptedSummonerId);
            ViewBag.SummonerRanks = summonerRanks;

            List<string> regions = _summonerLogic.GetRegions();
            ViewBag.RegionList = regions;

            return View();
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
