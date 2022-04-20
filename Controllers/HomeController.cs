using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefs_and_dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefs_and_dishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;
        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(s => s.Menu).OrderBy(a => a.LastName).ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("add/chef")]
        public IActionResult AddCheff()
        {
            return View("AddChef");
        }

        [HttpPost("chef/create")]
        public IActionResult CreateChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Chefs.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }

        [HttpGet("add/dish")]
        public IActionResult AddDish()
        {
            ViewBag.AllChefs = _context.Chefs.OrderBy(a => a.LastName).ToList();
            return View("AddDish");
        }

        [HttpPost("dish/create")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("AllDishes");
            } else {
                ViewBag.AllChefs = _context.Chefs.OrderBy(a => a.LastName).ToList();
                return View("AddDish");
            }
        }

        [HttpGet("all/dishes")]
        public IActionResult AllDishes()
        {
            ViewBag.AllDishes = _context.Dishes.Include(a => a.Chef).OrderBy(a => a.Name).ToList();
            return View("AllDishes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
