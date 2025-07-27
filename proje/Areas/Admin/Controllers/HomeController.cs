using Microsoft.AspNetCore.Mvc;

namespace proje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private const string adminUsername = "Mahmut Soysal";
        private const string adminPassword = "190877";

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(string username, string password)
        {
            if (username == adminUsername && password == adminPassword)
            {
                HttpContext.Session.SetString("AdminLoggedIn", "true");
                return RedirectToAction("index", "Home", new { area = "Admin" });
            }

            ViewBag.Error = "Kullanıcı adı veya şifre yanlış!";
            return View();
        }

        public IActionResult Index()
        {
            var loginCheck = HttpContext.Session.GetString("AdminLoggedIn");
            if (loginCheck != "true")
                return RedirectToAction("login");

            return View();
        }
    }
}
