using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemsida.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuyPics()
        {
            ViewBag.Title = "Fiskar, fiskar, fiskar...";

            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact us";

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About us";

            return View();
        }
    }
}
