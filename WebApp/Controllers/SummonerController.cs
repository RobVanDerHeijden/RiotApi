using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SummonerController : Controller
    {
        private readonly SummonerLogic _summonerLogic;

        // TODO: Add routes
        // TODO: Add viewmodels

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
            // GetSummonerList
            // If summoner is in summonerList
            SummonerViewModel sVmodel = new SummonerViewModel();
            sVmodel.Summoner = _summonerLogic.GetSummonerByName(region, id);
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