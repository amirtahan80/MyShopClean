﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.InterFaces.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace Controllers
{
    public class HomeController : Controller
    {
        #region Injections
        private readonly IHomePageServices _hoemPageServices;
        public HomeController(IHomePageServices hoemPageServices)
        {
            _hoemPageServices = hoemPageServices;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            var getHomePage = await _hoemPageServices.GetBanersAndProductsAsync();
            return View(getHomePage);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Errors(string errCode)
        {
            if (errCode == "500" | errCode == "404")
            {
                return View($"~/Views/Home/Errors/{errCode}.cshtml");
            }

            return View("~/Views/Shared/Errors.cshtml");
        }
    }
}
