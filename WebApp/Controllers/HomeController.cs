using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiotApi.API;
using RiotApi.Controller;
using RiotApi.Model;
using RiotApi.View.ViewModel;
using WebApp.Models;
using ViewModelMain = WebApp.Models.ViewModelMain;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ControllerMain _controllerMain;
        private ViewModelMain _viewModelMain;

        public HomeController()
        {
            _controllerMain = new ControllerMain();
            _viewModelMain = new ViewModelMain();
        }

        public IActionResult Index()
        {
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

        public IActionResult SummonerLookup()
        {
            List<string> Regions = new List<string>();
            Regions = _controllerMain.GetRegions();
            ViewBag.RegionList = Regions;
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SummonerLookup(ViewModelMain summoner)
        {
            
            
            if (_controllerMain.GetSummoner(summoner.Region, summoner.SummonerName))
            {
                Summoner_V4 summV4 = new Summoner_V4(summoner.Region);
                SummonerDTO summonerDto = summV4.GetSummonerByName(summoner.SummonerName);
                TempData["SummonerLevel"] = summonerDto.SummonerLevel;
                TempData["ProfileIconId"] = summonerDto.ProfileIconId;
            }
            else
            {
                Debug.WriteLine("Nope");
            }
            
            return RedirectToAction("SummonerLookup");
        }
        
    }
}
