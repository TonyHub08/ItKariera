using Microsoft.AspNetCore.Mvc;

namespace ItKariera.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View("Profile");
        }
    }
}
