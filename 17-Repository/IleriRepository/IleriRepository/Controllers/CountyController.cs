using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class CountyController : Controller
    {
        IUnit _uow;
        CountyModel _model;

        public CountyController(IUnit uow, CountyModel model)
        {
            _uow = uow;
            _model = model;
        }

        public IActionResult List()
        {
            var cList = _uow._countyRep.GetCounties();
            return View(cList);
        }
        public IActionResult Create()
        {
            _model.Head = "New Entry";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-primary";
            _model.Cities = _uow._cityRep.List();
            _model.County = new County();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CountyModel model)
        {
            model.County.CreatedDate = DateTime.Now;
            _uow._countyRep.Add(model.County);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            _model.Head = "Edit County";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-success";
            _model.Cities = _uow._cityRep.List();
            _model.County = _uow._countyRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CountyModel model)
        {
            _uow._countyRep.Update(model.County);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            _model.Head = "Delete County";
            _model.BtnText = "Delete";
            _model.BtnCls = "btn btn-danger";
            _model.Cities = _uow._cityRep.List();
            _model.County = _uow._countyRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CountyModel model)
        {
            _uow._countyRep.Delete(model.County.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
