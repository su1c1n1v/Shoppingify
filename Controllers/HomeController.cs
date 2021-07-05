using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shoppingify.Data.Interface;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IProductsRepository _productsRepo;

        public HomeController(ILogger<HomeController> logger)
        //public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager,
          //  ICategoryRepository categoryRepo, IProductsRepository productsRepo)
        {
            _logger = logger;
            /*_userManager = userManager;
            _categoryRepo = categoryRepo;
            _productsRepo = productsRepo;*/
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
