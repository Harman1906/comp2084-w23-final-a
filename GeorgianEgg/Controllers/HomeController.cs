﻿using GeorgianEgg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeorgianEgg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hey class!";

            return View("Index");
        }

        public IActionResult Support()
        {
            ViewData["Message"] = "Hey class!";

            return View("Support");
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