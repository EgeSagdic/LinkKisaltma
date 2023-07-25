using LinkKisaltma.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinkKisaltma.Controllers
{
    public class YonlendirController : Controller
    {
        [Route("/{GelenLink}")]
        public IActionResult Index(string GelenLink)
        {
            DatabaseContext db = new DatabaseContext();
            var BulunanData = db.TBLLink.Where(x => x.KisaLink == GelenLink).FirstOrDefault();
            if (BulunanData != null)
            {
                BulunanData.NumberOfClicks++;
                db.SaveChanges();
               return Redirect(BulunanData.UzunLink);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }
    }
}
