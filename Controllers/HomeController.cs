using BirthdayCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult SubmissionForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmissionForm(CardDetails cardDetails)
        {
            if (ModelState.IsValid)
            {
                return View("SentCard", cardDetails);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Index()
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