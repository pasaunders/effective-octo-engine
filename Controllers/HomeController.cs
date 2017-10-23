using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
