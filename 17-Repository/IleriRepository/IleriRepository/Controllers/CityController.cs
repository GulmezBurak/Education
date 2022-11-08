using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class CityController : Controller
    {

        IUnit _uow;
        CityModel _model;

        public CityController(IUnit uow, CityModel model)
        {
            _uow = uow;
            _model = model;
        }

        public IActionResult List()
        {
            var cList = _uow._cityRep.List();
            return View(cList);
        }
        public IActionResult Create()
        {
            _model.Head = "New Entry";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-primary";
            _model.City = new City();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            model.City.CreatedDate = DateTime.Now;
            _uow._cityRep.Add(model.City);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            _model.Head = "Edit City";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-success";
            _model.City = _uow._cityRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CityModel model)
        {
            _uow._cityRep.Update(model.City);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            _model.Head = "Delete City";
            _model.BtnText = "Delete";
            _model.BtnCls = "btn btn-danger";
            _model.City = _uow._cityRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _uow._cityRep.Delete(model.City.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }

    }
}
