using lab27_miya.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab27_miya.Controllers
{
    public class HomeController : Controller
    {
        private readonly lab27_miyaContext _context;

        public HomeController(lab27_miyaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.CPS.Where(c => c.ID == 1);
            
            return View(result.ToList());
        }
    }
}

