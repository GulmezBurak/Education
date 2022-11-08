using _1_FirstEF.Context;
using _1_FirstEF.Data;
using _1_FirstEF.DTO;
using _1_FirstEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_FirstEF.Controllers
{
    public class ProductsController : BaseController
    {
        ProductsModel _model;
        public ProductsController(SatisContext _db, ProductsModel model) : base(_db)
        {
            _model = model;
        }
        public List<Categories> GetCategories()
        {
            return _db.Set<Categories>().ToList();
        }
        public IActionResult List()
        {
            var plist = _db.Set<Products>().Select(x => new ProductsDTO
            {
                Id = x.Id,
                Price = x.Price,
                ProductName = x.ProductName,
                CategoryName = x.Categories.CategoryName,  //inner join ediyor
            }).ToList();
            return View(plist);
        }
        public IActionResult Create()
        {
            _model.Products = new Products();
            _model.Categories = GetCategories();
            _model.Head = "New Entry";
            _model.Cls = "btn btn-primary";
            _model.Text = "Save";
            return View("Crud",_model);
        }
        [HttpPost]
        public IActionResult Create(ProductsModel model)
        {
            _db.Set<Products>().Add(model.Products);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            _model.Categories = GetCategories();
            _model.Products = _db.Set<Products>().Find(id);
            _model.Head = "Update";
            _model.Cls = "btn btn-success";
            _model.Text = "Save";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(ProductsModel model)
        {
            _db.Set<Products>().Update(model.Products);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var pro = _db.Set<Products>().Find(id);
            _db.Set<Products>().Remove(pro);
            _db.SaveChanges();
            return RedirectToAction("List");

        }

    }
    
}
