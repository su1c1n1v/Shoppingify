using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shoppingify.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Controllers
{
    public class HistoricController : Controller
    {
        private readonly ILogger<HistoricController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IProductsRepository _productsRepo;

        public HistoricController(ILogger<HistoricController> logger)
        //public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager,
        //  ICategoryRepository categoryRepo, IProductsRepository productsRepo)
        {
            _logger = logger;
            /*_userManager = userManager;
            _categoryRepo = categoryRepo;
            _productsRepo = productsRepo;*/
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Historic()
        {
            return View();
        }
    }
}
