using Microsoft.AspNetCore.Mvc;

namespace ItKariera.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Add()
        {
            return View("Add");
        }
    }
}
