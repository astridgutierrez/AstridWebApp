﻿using Microsoft.AspNetCore.Mvc;

namespace AstridWebApp.Controllers
{
    public class AstridController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();
        }
    }
}
