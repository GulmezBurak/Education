using Dapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProje.Data;
using PersonelProje.DTO_datatransferobject;
using PersonelProje.Models;

namespace PersonelProje.Controllers
{
    public class PersonelController : BaseController
    {
        PersonelModel _model;
        public PersonelController(IConfiguration config, PersonelModel model) : base(config)
        {
            _model = model;
        }
        public Personel GetPersonel(int Id)
        {
            return Connect().Query<Personel>($"select * from Personel where Id = '{Id}'").FirstOrDefault();
        }
        public List<Ulke> GetUlkeler()
        {
            return Connect().Query<Ulke>("Select * from Ulke").ToList();
        }
        public List<Sehir> GetSehirler()
        {
            return Connect().Query<Sehir>("Select * from Sehir").ToList();
        }

        public IActionResult Liste()
        {
            var qry = "select p.Id, Ad + ' ' + Soyad Adsoyad , Maas, s.SehirAd SehirAd, u.UlkeAd UlkeAd from Personel p inner join Sehir s on p.SehirId = s.Id inner join Ulke u on p.UlkeId = u.Id";
            var personelList = Connect().Query<PersonelDTO>(qry).ToList();
            return View(personelList);
        }
        public IActionResult Guncel(int Id)
        {
            _model.Personel = GetPersonel(Id);
            _model.Sehirler = GetSehirler();
            _model.Ulkeler = GetUlkeler();
            _model.Baslik = "Güncelleme İşlemi";
            _model.BtnText = "Güncelle";
            _model.BtnClass = "btn btn-success";
            return View("Genel",_model);
        }
        [HttpPost]
        public IActionResult Guncel(Personel model)
        {
            string qry = $"Update Personel set Ad = @Ad, Soyad = @Soyad, Maas = @Maas," +
                $"SehirId = @SehirId, UlkeId = @UlkeId where Id = @Id";
            Connect().ExecuteScalar<Personel>(qry, model);
            return RedirectToAction("Liste");
        }

        public IActionResult Giris()
        {
            _model.Personel = new Personel();
            _model.Sehirler = GetSehirler();
            _model.Ulkeler = GetUlkeler();
            _model.Baslik = "Yeni Giriş";
            _model.BtnText = "Kaydet";
            _model.BtnClass = "btn btn-primary";
            return View("Genel",_model);
        }
        [HttpPost]
        public IActionResult Giris(Personel model)
        {
            string qry = $"Insert into Personel (Ad , Soyad, Maas, SehirId , UlkeId) values(@Ad, @Soyad, @Maas, @SehirId , @UlkeId)";
            Connect().ExecuteScalar<Personel>(qry, model);
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            _model.Personel = GetPersonel(Id);
            _model.Sehirler = GetSehirler();
            _model.Ulkeler = GetUlkeler();
            _model.Baslik = "Silme İşlemi";
            _model.BtnText = "Sil";
            _model.BtnClass = "btn btn-danger";
            return View("Genel",_model);
        }
        [HttpPost]
        public IActionResult Sil(Personel model)
        {
            string qry = $"delete from Personel where Id = @Id";
            Connect().ExecuteScalar<Personel>(qry, model);
            return RedirectToAction("Liste");
        }
    }
}
