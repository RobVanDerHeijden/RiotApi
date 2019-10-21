using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using RiotApi.API;
using RiotApi.Controller;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ControllerMain _controllerMain;
        private SummonerLogic _summonerLogic;

        public HomeController(ISummonerContext summonerContext)
        {
            _controllerMain = new ControllerMain();
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
                Summoner_V4 summV4 = new Summoner_V4(summonerViewModel.Region);

                //SummonerDTO summonerDto = summV4.GetSummonerByName(summonerViewModel.SummonerName); 
                Summoner summoner = _summonerLogic.GetSummonerByName(summonerViewModel.Region, summonerViewModel.SummonerName); // TODO: this is second API call. Is it needed??
                TempData["SummonerLevel"] = summoner.SummonerLevel;
                TempData["ProfileIconId"] = summoner.ProfileIconId;

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
