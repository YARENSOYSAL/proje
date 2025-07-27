using Microsoft.AspNetCore.Mvc;
using proje.Models;
using System.Linq;

namespace proje.Controllers
{
    public class SikayetlerController : Controller
    {
        private readonly DataContext _context;

        public SikayetlerController(DataContext context)
        {
            _context = context;
        }

        // Listeleme + inline güncelleme için
        public IActionResult Index(int? guncelleId = null)
        {
            var sikayetler = _context.Sikayetler.ToList();
            ViewBag.GuncelleId = guncelleId; // hangi şikayet düzenleniyor
            return View(sikayetler);
        }

        // Yeni şikayet ekleme
        [HttpPost]
        public IActionResult Ekle(Sikayet yeniSikayet)
        {
            if (ModelState.IsValid)
            {
                _context.Sikayetler.Add(yeniSikayet);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Şikayet silme
        [HttpPost]
        public IActionResult Sil(int id)
        {
            var sikayet = _context.Sikayetler.Find(id);
            if (sikayet != null)
            {
                _context.Sikayetler.Remove(sikayet);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // Şikayet güncelleme (aynı sayfa içinde)
        [HttpPost]
        public IActionResult Guncelle(Sikayet guncellenenSikayet)
        {
            if (ModelState.IsValid)
            {
                var mevcut = _context.Sikayetler.FirstOrDefault(x => x.Id == guncellenenSikayet.Id);
                if (mevcut != null)
                {
                    mevcut.Ad = guncellenenSikayet.Ad;
                    mevcut.Soyad = guncellenenSikayet.Soyad;
                    mevcut.Icerik = guncellenenSikayet.Icerik;

                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
