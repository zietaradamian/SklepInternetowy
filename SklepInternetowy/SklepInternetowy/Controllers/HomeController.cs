using SklepInternetowy.DAL;
using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext();
        // GET: Home
        public ActionResult Index()
        {
            Kategoria kategoria = new Kategoria
            {
                NazwaKategorii = "asp.net mvc",
                NazwaPlikuIkony = "aspNetMvc.png",
                OpisKategorii = "Opis"
               
            };
            db.Kategorie.Add(kategoria);
            db.SaveChanges();
            return View();
        }
    }
}