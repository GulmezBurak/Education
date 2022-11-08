using Dapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProje.Data;

namespace PersonelProje.Controllers
{
    public class SehirController : BaseController
    {
        public SehirController(IConfiguration config) : base(config)
        {
        }

        public IActionResult Liste()
        {
            var qry = "Select * from Sehir";
            var sehirler = Connect().Query<Sehir>(qry).ToList();
            return View(sehirler);
        }

        public IActionResult Guncel(int Id)
        {
            var secSehir = SehirSec(Id);
            return View(secSehir);
        }
        [HttpPost]
        public IActionResult Guncel(Sehir sehir)
        {
            var qry = $"update Sehir set SehirAd = @SehirAd where Id = @Id";
            Connect().ExecuteScalar<int>(qry, sehir);
            return RedirectToAction("Liste");
        }
        public IActionResult Sil(int Id)
        {
            var secSehir = SehirSec(Id);
            return View(secSehir);
        }
        [HttpPost]
        public IActionResult Sil(Sehir sehir)
        {
            var qry = $"delete from Sehir where Id = @Id";
            Connect().ExecuteScalar<int>(qry, sehir);
            return RedirectToAction("Liste");
        }
        public IActionResult Ekle(Sehir yeniSehir)
        {

            return View(yeniSehir);
        }
        [HttpPost]
        public IActionResult Ekle(Sehir sehir, bool d)
        {
            var qry = $"insert into Sehir (Id,SehirAd) values(@Id,@SehirAd)";
            Connect().ExecuteScalar<int>(qry, sehir);
            return RedirectToAction("Liste");
        }
        public Sehir SehirSec(int Id)
        {
            var qry = $"Select * from Sehir where Id = '{Id}' ";
            return Connect().Query<Sehir>(qry).FirstOrDefault();
        }

    }
}
