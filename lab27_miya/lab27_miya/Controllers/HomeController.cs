using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab27_miya.Controllers
{
    public class HomeController : Controller
    {
        //private lab27_miyaContext _context;

        //public HomeController(lab26_miyaContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            //var result = _context.CPS.Where(c => c.ID == 1);
            //result.ToList() - put this is View

            return View();
        }
    }
}

