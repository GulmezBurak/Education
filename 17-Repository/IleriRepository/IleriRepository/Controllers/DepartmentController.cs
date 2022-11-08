using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class DepartmentController : Controller
    {
        IUnit _uow;
        DepartmentModel _model;
        public DepartmentController(IUnit uow, DepartmentModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            return View(_uow._departmentRep.List());
        }
        public IActionResult Create()
        {
            _model.Head = "New Entry";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-primary";
            _model.Department = new Department();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(DepartmentModel model)
        {
            _uow._departmentRep.Add(model.Department);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            _model.Head = "Update Department";
            _model.BtnText = "Save";
            _model.BtnCls = "btn btn-success";
            _model.Department = _uow._departmentRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentModel model)
        {
            _uow._departmentRep.Update(model.Department);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            _model.Head = "Delete Department";
            _model.BtnText = "Delete";
            _model.BtnCls = "btn btn-danger";
            _model.Department = _uow._departmentRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(DepartmentModel model)
        {
            _uow._departmentRep.Delete(model.Department.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
