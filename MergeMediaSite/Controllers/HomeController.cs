using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MergeMediaSite.Models;

namespace MergeMediaSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Home Page";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Technologies()
        {
            ViewData["Message"] = "Technologies.";
            return View();
        }
        public IActionResult Portfolio()
        {
            ViewData["Message"] = "Portfolio Page";
            return View();
        }
        public IActionResult Hosting()
        {
            ViewData["Message"] = "Hosting Page";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
