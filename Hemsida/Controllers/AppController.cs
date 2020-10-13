using Hemsida.Data;
using Hemsida.Services;
using Hemsida.ViewModels;
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
        private readonly IMailService _mailService;
        private readonly IHemsidaRepository _repository;

        public AppController(IMailService mailService, IHemsidaRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }

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
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send email
                _mailService.SendMessage("per.j.stensland@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail sent";
                ModelState.Clear();
            }
            else
            {
                // Errors
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About us";

            return View();
        }

        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts()
                .OrderBy(p => p.Category)
                .ToList();

            return View(results);
        }
    }
}
