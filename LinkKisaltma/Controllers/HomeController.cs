using LinkKisaltma.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinkKisaltma.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string UserLink)
        {
            string YeniKisaKod = "";

            DatabaseContext db = new DatabaseContext();
            do
            {
                YeniKisaKod = new Random().Next(0,999999).ToString();

            } while (db.TBLLink.Any(x=> x.KisaLink == YeniKisaKod));

            TBLLink l = new TBLLink();
            l.UzunLink = UserLink;
            l.KisaLink = YeniKisaKod;
            db.TBLLink.Add(l);
            db.SaveChanges();

            ViewBag.Mesaj = "Linkiniz : kisalt.sagdic.com/" + YeniKisaKod;
            return View();
        }
    }
}
