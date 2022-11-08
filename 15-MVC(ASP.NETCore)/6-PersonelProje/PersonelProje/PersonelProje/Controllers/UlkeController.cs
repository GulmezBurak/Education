using Dapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProje.Data;
using System.Data.SqlClient;

namespace PersonelProje.Controllers
{
    public class UlkeController : BaseController
    {
        public UlkeController(IConfiguration config) : base(config)
        {
        }

        //IConfiguration _config;

        //public UlkeController(IConfiguration config)
        //{
        //    _config = config;
        //}
        //public SqlConnection Connect()
        //{
        //    return new SqlConnection(_config.GetConnectionString("Baglanti"));
        //} //base controllerda bunları yazdık..
        public IActionResult Liste()
        {
            var qry = "Select * from Ulke";
            var ulkeler = Connect().Query<Ulke>(qry).ToList();
            return View(ulkeler);
        }
      
        public IActionResult Guncel(string Id)
        {
            var secUlke = UlkeSec(Id);
            return View(secUlke);
        }
        [HttpPost]
        public IActionResult Guncel(Ulke ulke)
        {
            //SqlConnection con = new SqlConnection(_config.GetConnectionString("Baglanti")); //metod olarak yazdığımız için gerek yok.
            var qry = $"update Ulke set UlkeAd = @UlkeAd where Id = @Id";
            //1.Yol daha iyi
            Connect().ExecuteScalar<int>(qry, ulke);

            //2.Yol
            //DynamicParameters par = new DynamicParameters();
            //par.Add("@UlkeAd", ulke.UlkeAd);
            //par.Add("@Id", ulke.Id);
            //con.ExecuteScalar<int>(qry,par);
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(string Id)
        {
            var secUlke = UlkeSec(Id);
            return View(secUlke);
        }
        [HttpPost]
        public IActionResult Sil(Ulke ulke)
        {
            //SqlConnection con = new SqlConnection(_config.GetConnectionString("Baglanti"));
            var qry = $"delete from Ulke where Id = @Id";
            Connect().ExecuteScalar<int>(qry, ulke);
            return RedirectToAction("Liste");
        }
        public IActionResult Ekle(Ulke yeniUlke)
        {

            return View(yeniUlke);
        }
        [HttpPost]
        public IActionResult Ekle(Ulke ulke, bool d)
        {
            var qry = $"insert into Ulke (Id,UlkeAd) values(@Id,@UlkeAd)";
            Connect().ExecuteScalar<int>(qry, ulke);
            return RedirectToAction("Liste");
        }
        public Ulke UlkeSec(string Id)
        {
            //SqlConnection con = new SqlConnection(_config.GetConnectionString("Baglanti"));
            var qry = $"Select * from Ulke where Id = '{Id}' ";
            return Connect().Query<Ulke>(qry).FirstOrDefault();
        }
    }
}
