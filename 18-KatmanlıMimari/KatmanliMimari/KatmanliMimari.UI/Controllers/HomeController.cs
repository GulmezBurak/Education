using KatmanliMimari.Ent;
using KatmanliMimari.UI.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KatmanliMimari.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnit _uow;
        PersonnalModel _model;

        public HomeController(ILogger<HomeController> logger, IUnit uow, PersonnalModel model)
        {
            _logger = logger;
            _uow = uow;
            _model = model;
        }

        public IActionResult Index()
        {
            var ls = _uow._personelRep.List();
            return View(ls); 
        }
        public IActionResult Create()
        {
            _model.Head = "New Entry";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-primary";
            _model.Personnal = new Personnal();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(PersonnalModel model)
        {
            _uow._personelRep.Add(model.Personnal);
            _uow.Commit();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            _model.Head = "Edit Personnal";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-success";
            _model.Personnal = _uow._personelRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(PersonnalModel model)
        {
            _uow._personelRep.Update(model.Personnal);
            _uow.Commit();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            _model.Head = "Delete Personnal";
            _model.BtnText = "Delete";
            _model.BtnCls = "btn btn-danger";
            _model.Personnal = _uow._personelRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(PersonnalModel model)
        {
            _uow._personelRep.Delete(model.Personnal.Id);
            _uow.Commit();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}