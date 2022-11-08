using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class GradeController : Controller
    {
        IUnit _uow;
        GradeModel _model;
        public GradeController(IUnit uow, GradeModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            return View(_uow._gradeRep.List());
        }
        public IActionResult Create()
        {
            _model.Head = "New Entry";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-primary";
            _model.Grade = new Grade();
            return View("Crud",_model);
        }
        [HttpPost]
        public IActionResult Create(GradeModel model)
        {
            _uow._gradeRep.Add(model.Grade);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(string Id)
        {
            _model.Head = "Update Grade";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-success";
            _model.Grade = _uow._gradeRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(GradeModel model)
        {
            _uow._gradeRep.Update(model.Grade);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(string Id)
        {
            _model.Head = "Delete City";
            _model.BtnText = "Delete";
            _model.BtnCls = "btn btn-danger";
            _model.Grade = _uow._gradeRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(GradeModel model)
        {
            _uow._gradeRep.Delete(model.Grade.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
