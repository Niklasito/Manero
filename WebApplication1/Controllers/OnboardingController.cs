﻿using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class OnboardingController : Controller
    {
        public IActionResult Welcome()
        {
            
            return View("Welcome");
        }

       


        public IActionResult Index()
        {
            ViewData["HomeLink"] = "<a asp-controller=\"home\" asp-action=\"index\"></a>";
            return View("Index");
        }

    }

}
