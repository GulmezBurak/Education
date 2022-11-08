using Microsoft.AspNetCore.Mvc;
using MvcModel.Models;
using System.Diagnostics;

namespace MvcModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact([FromServices] Webmaster _webmaster)
        {
            // 1. Yol A ViewBag
            //Webmaster wb = new Webmaster(); program.cs de builder services eklediğimiz için gerek yok.
            _webmaster.Id = 1;
            _webmaster.Ad = "Esra";
            _webmaster.Soyad = "Çetin";
            _webmaster.Mail = "esracetin@gmail.com";
            ViewBag.Id = _webmaster.Id.ToString();
            ViewBag.Ad = _webmaster.Ad;
            ViewBag.Soyad = _webmaster.Soyad;
            ViewBag.Mail = _webmaster.Mail;
           
            //1.Yol B ViewBag
            ViewBag.Webmaster = _webmaster;
            return View();
        }
        public IActionResult Contact2([FromServices] Webmaster _webmaster)
        {
            //Webmaster wb = new Webmaster();
            _webmaster.Id = 1;
            _webmaster.Ad = "Esra";
            _webmaster.Soyad = "Çetin";
            _webmaster.Mail = "esracetin@gmail.com";
           
            return View(_webmaster);
        }
        // 3 kişilik personel listesi yazdır
        public IActionResult PersonelListe(List<Webmaster> _webmasters, Webmaster _webmaster, Webmaster _webmaster1)
        {
            _webmaster.Ad = "Esra";
            _webmaster.Soyad = "Çetin";
            _webmaster.Id = 1;
            _webmasters.Add(_webmaster);

            _webmaster1.Ad = "Burak";
            _webmaster1.Soyad = "Gülmez";
            _webmaster1.Id = 2;
            _webmasters.Add(_webmaster1);
            ViewBag.Liste = _webmasters;


            return View(_webmasters);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}