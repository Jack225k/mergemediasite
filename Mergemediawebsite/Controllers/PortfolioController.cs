using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mergemediawebsite.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Demo1")]
        public IActionResult Demo1()
        {
            ViewData["Message"] = "About Page";

            return Redirect("~/lib/demo/aligned/index.html");
        }
    }
}