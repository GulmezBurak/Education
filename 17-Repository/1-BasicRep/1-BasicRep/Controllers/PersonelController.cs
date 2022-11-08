using _1_BasicRep.Context;
using _1_BasicRep.Data;
using _1_BasicRep.Models;
using _1_BasicRep.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _1_BasicRep.Controllers
{
    public class PersonelController : Controller
    {
        Repos<Personel> _repos;
        PersonelModel _model;
        public PersonelController(Repos<Personel> repos, PersonelModel model)
        {
            _repos = repos;
            _model = model;
        }
        public IActionResult List()
        {
            //var plist = _db.Set<Personel>().ToList();
            var plist = _repos.List();
            return View(plist);
        }
        public IActionResult Create()
        {
            
            _model.Head = "New Personel";
            _model.Text = "Save";
            _model.Cls = "btn btn-primary";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(PersonelModel m)
        {
            _repos.Create(m.Personel);
            _repos.Save();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            _model.Personel = _repos.Find(Id);
            _model.Head = "Update";
            _model.Text = "Save";
            _model.Cls = "btn btn-success";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(PersonelModel m)
        {
            _repos.Update(m.Personel);
            _repos.Save();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            var personel = _repos.Find(Id);
            _repos.Delete(personel);
            _repos.Save();
            return RedirectToAction("List");
        }
    }
}
