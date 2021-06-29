using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shoppingify.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Items()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
