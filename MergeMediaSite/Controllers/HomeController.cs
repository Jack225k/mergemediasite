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
        private readonly ClassContext _context;

        public HomeController(ClassContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Home Page";
            return View();
        }

        [Route("About")]

        public IActionResult About()
        {
            ViewData["Message"] = "About Page";

            return View();
        }

        [Route("Technologies")]
        public IActionResult Technologies()
        {
            ViewData["Message"] = "Technologies.";
            return View();
        }

        [Route("Portfolio")]
        public IActionResult Portfolio()
        {
            ViewData["Message"] = "Portfolio Page";
            return View();
        }
        [Route("Hosting")]
        public IActionResult Hosting()
        {
            ViewData["Message"] = "Hosting Page";
            return View(_context.HostingTables.ToList());
        }
        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Us";

            return View();
        }

        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View("~/Views/Shared/err404.cshtml");
        }
    }
}
