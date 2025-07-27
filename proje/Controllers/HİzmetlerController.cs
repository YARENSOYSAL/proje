using Microsoft.AspNetCore.Mvc;

namespace proje.Controllers
{
    public class HizmetlerController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
