using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop.Areas.Holidaies.Controllers
{
    [Area("Holidaies")]
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
