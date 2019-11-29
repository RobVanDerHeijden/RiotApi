using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SummonerController : Controller
    {
        private readonly SummonerLogic _summonerLogic;
        
        public SummonerController(ISummonerContext summonerContext)
        {
            _summonerLogic = new SummonerLogic(summonerContext);
        }
        // GET: Summoner
        public ActionResult Index()
        {
            // GetSummonerList
            //return View(summoners);
            return View();
        }

        // GET: Summoner/Details/5
        public ActionResult Details(string id, string region)
        {
            SummonerViewModel sVmodel = new SummonerViewModel();

            // API CALL #1
            Summoner summoner = _summonerLogic.GetSummonerByName(region, id);
            if (summoner == null)
            {
                // TODO: Make this a redirect? to a summoner not found page perhaps
                TempData["SummonerName"] = "SUMMONER NOT FOUND";
            }
            else
            {
                sVmodel.Summoner = summoner;

                // API CALL #2 + 1 Per Match
                SummonerPlayedGamesList summonerPlayedGames = _summonerLogic.GetSummonerPlayedGames(region, summoner);
                sVmodel.SummonerPlayedGames = summonerPlayedGames.Matches;

                // API CALL #3
                List<Rank> summonerRanks = _summonerLogic.GetSummonerRanks(region, summoner.EncryptedSummonerId);
                sVmodel.SummonerRanks = summonerRanks;
                // API CALL tbd
                // TODO: get the leaguename from each rank

                // API CALLSSS tbd
                // TODO: get the summoner-champions + mastery(MASTERY IS SEPERATE CALL) + winrate and KDA (FIGURE OUT HOW I WANT TO CALCULATE THIS)
            }

            sVmodel.RegionList = _summonerLogic.GetRegions();
            
            return View(sVmodel);
        }

        //// GET: Summoner/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Summoner/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Summoner/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Summoner/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


    }
}