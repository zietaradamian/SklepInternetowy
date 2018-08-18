using SklepInternetowy.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class KursyController : Controller
    {
        private KursyContext db = new KursyContext();
        // GET: Kursy
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista(string nazwaKategori)
        {
            var kategoria = db.Kategorie.Include("Kursy").Where(k => k.NazwaKategorii.ToUpper() == nazwaKategori.ToUpper()).Single();
            var kursy = kategoria.Kursy.ToList();
            return View(kursy);
        }
        public ActionResult Szczegoly(int id)
        {
            var kurs = db.Kursy.Find(id);

            return View(kurs);
        }
        [ChildActionOnly]
        [OutputCache(Duration = 60000)]
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();

            return PartialView("_KategorieMenu",kategorie);
        }

    }
}