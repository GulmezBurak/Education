using _1_FirstEF.Context;
using _1_FirstEF.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1_FirstEF.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(SatisContext _db) : base(_db)
        {
        }

        public IActionResult List()
        {
            var clist = _db.Set<Categories>().ToList();
            return View(clist);
        }
        public IActionResult Create(Categories cat)
        {
            return View("Crud",cat);
        }
        [HttpPost]
        public IActionResult Create(Categories cat, bool asdf)
        {
            _db.Set<Categories>().Add(cat);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            Categories cat = _db.Set<Categories>().Find(id);
            return View("Crud", cat);
        }
        [HttpPost]
        public IActionResult Edit(Categories cat)
        {
            _db.Set<Categories>().Update(cat);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            var cat = _db.Set<Categories>().Find(id);
            _db.Set<Categories>().Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("List");

        }
        public IActionResult Detail(int Id)
        {
            var p = _db.Set<Categories>().Include(x => x.Products).Where(x => x.Id == Id).FirstOrDefault();
            return View(p);
        }
    }
}
