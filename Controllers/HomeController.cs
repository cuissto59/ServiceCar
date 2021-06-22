using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using serviceCar.Models;
using serviceCar.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace serviceCar.Controllers
{
    public class HomeController : Controller
    {
        private servicecarContext _context;
        private readonly ILogger<HomeController> _logger;
        public String methodUsed="Index";
        public HomeController(ILogger<HomeController> logger, servicecarContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            methodUsed="Index";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        public IActionResult ContactUs()
        {
            methodUsed="ContactUs";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        public IActionResult AboutUs()
        {
            methodUsed="AboutUs";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        public IActionResult Privacy()
        {
            methodUsed="Privacy";
            ViewBag.methodUsed=methodUsed;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
