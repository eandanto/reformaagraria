using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reformaagraria.Data;

namespace reformaagraria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReformaAgrariaDataContext db;
        public HomeController(ReformaAgrariaDataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
