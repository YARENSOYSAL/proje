using Microsoft.AspNetCore.Mvc;
using proje.Models;
using System.Linq;

namespace proje.Controllers
{
    public class YorumlarController : Controller
    {
        private readonly DataContext _context;

        public YorumlarController(DataContext context)
        {
            _context = context;
        }

        // Yorumları listeleme + aynı sayfada inline güncelleme için
        public IActionResult Index(int? guncelleId = null)
        {
            var yorumlar = _context.Yorumlar.ToList();
            ViewBag.GuncelleId = guncelleId; // Hangi yorum düzenleniyor
            return View(yorumlar);
        }

        // Yeni yorum ekleme
        [HttpPost]
        public IActionResult Ekle(Yorum yeniYorum)
        {
            if (ModelState.IsValid)
            {
                _context.Yorumlar.Add(yeniYorum);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Yorum silme
        [HttpPost]
        public IActionResult Sil(int id)
        {
            var yorum = _context.Yorumlar.Find(id);
            if (yorum != null)
            {
                _context.Yorumlar.Remove(yorum);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Yorum güncelleme (aynı sayfa içinde)
        [HttpPost]
        public IActionResult Guncelle(Yorum guncellenenYorum)
        {
            if (ModelState.IsValid)
            {
                var mevcut = _context.Yorumlar.FirstOrDefault(x => x.Id == guncellenenYorum.Id);
                if (mevcut != null)
                {
                    mevcut.Ad = guncellenenYorum.Ad;
                    mevcut.Soyad = guncellenenYorum.Soyad;
                    mevcut.Icerik = guncellenenYorum.Icerik;

                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
