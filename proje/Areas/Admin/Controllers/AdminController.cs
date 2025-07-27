using Microsoft.AspNetCore.Mvc;
using proje.Models;  // Model ve DataContext burada

namespace proje.Controllers  // veya Areas.Admin.Controllers olabilir
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        
        private readonly DataContext _context;

        public AdminController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Yorumlar()
        {
            var yorumlar = _context.Yorumlar.ToList();  // Tarihe göre sıralama kaldırıldı
            return View(yorumlar);
        }
        public IActionResult Sikayetler()
        {
            var sikayetler = _context.Sikayetler.ToList();  // Tarihe göre sıralama kaldırıldı
            return View(sikayetler);
        }

    }
}
