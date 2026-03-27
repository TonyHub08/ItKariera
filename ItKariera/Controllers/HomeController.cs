using ItKariera.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ItKariera.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        public IActionResult Add()
        {
            return View("Add");
        }

        public IActionResult Profile()
        {
            return View("Profile");
        }

        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        public IActionResult SignUp()
        {
            return View("SignUp");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
