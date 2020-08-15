﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models.ViewModels;

namespace SalesWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ( )
        {
            return View();
        }

        public IActionResult About ( )
        {
            ViewData["Message"] = "Salles web MVC App from C# Course";
            ViewData["email"] = "gabriel_gamboa10@hotmail.com";

            return View();
        }

        public IActionResult Contact ( )
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy ( )
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error ( )
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
