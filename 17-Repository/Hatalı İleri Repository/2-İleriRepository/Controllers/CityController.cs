using _2_İleriRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace _2_İleriRepository.Controllers
{
    public class CityController : Controller
    {
        IUnit _uow;
        public CityController(IUnit uow)
        {
            _uow = uow;
        }
    
        public IActionResult List()
        {
            var clist = _uow._cityRep.List();
            return View(clist);
        }
    }
}
