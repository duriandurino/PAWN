using Microsoft.AspNetCore.Mvc;
using Pawn.Models;
using System.Diagnostics;

namespace Pawn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult CustomerForm()
        {
            return View();
        }
        public IActionResult CustomerUpdate()
        {
            return View();
        }
        public IActionResult SMSConfig()
        {
            return View();
        }
        public IActionResult SMSMessaging()
        {
            return View();
        }
        public IActionResult PawnTicket()
        {
            return View();
        }
        public IActionResult PawnTicketGenerate()
        {
            return View();
        }
        public IActionResult PawnTicketForm()
        {
            return View();
        }
        public IActionResult Renewal()
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