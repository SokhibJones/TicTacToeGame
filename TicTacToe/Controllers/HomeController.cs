using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string xPlayer, string oPlayer)
        {
            if (string.IsNullOrWhiteSpace(xPlayer) || string.IsNullOrWhiteSpace(oPlayer))
            {
                return RedirectToAction(nameof(LoginPage));
            }

            ViewBag.Player1 = xPlayer;
            ViewBag.Player2 = oPlayer;

            return View();
        }

        public IActionResult LoginPage()
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