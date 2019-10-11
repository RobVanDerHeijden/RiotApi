using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public HomeController()
        {
            _controllerMain = new ControllerMain();
        }

        public IActionResult Index()
        {
            List<string> regions = _controllerMain.GetRegions();
            ViewBag.RegionList = regions;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ViewModelMain summoner)
        {
            if (_controllerMain.DoesSummonerExist(summoner.Region, summoner.SummonerName))
            {
                Summoner_V4 summV4 = new Summoner_V4(summoner.Region);

                //SummonerDTO summonerDto = summV4.GetSummonerByName(summoner.SummonerName); 
                Summoner summoner2 = summV4.GetSummonerByName(summoner.SummonerName); // TODO: this is second API call. Is it needed??
                TempData["SummonerLevel"] = summoner2.SummonerLevel;
                TempData["ProfileIconId"] = summoner2.ProfileIconId;
            }
            else
            {
                Debug.WriteLine("No summoner found.");
            }

            List<string> regions = _controllerMain.GetRegions();
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
