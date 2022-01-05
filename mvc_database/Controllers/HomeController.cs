using Microsoft.AspNetCore.Mvc;
using mvc_database.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_database.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var stuList = _context.Students.ToList();
            return View(stuList);
        }
    }
}
