using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }
        public IActionResult Time()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult List2()
        {
            return View();
        }
        public IActionResult List3()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Daohang()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
