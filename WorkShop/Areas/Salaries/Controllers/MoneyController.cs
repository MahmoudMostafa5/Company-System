using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop.Areas.Salaries.Controllers
{
    [Area("Salaries")]
    public class MoneyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
