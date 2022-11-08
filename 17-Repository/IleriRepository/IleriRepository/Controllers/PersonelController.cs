using IleriRepository.Data;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class PersonelController : Controller
    {
        IUnit _uow;
        public PersonelController(IUnit uow)
        {
            _uow = uow;
        }
        public IActionResult ListbyGrade()
        {
            return View(_uow._personelRep.ListByGrades());
        }
        public IActionResult Details(int Id)
        { // Eager Load. Bağlantılar boş gelir.
            // Lazy Load olursa bağlantılar dolu gelir. Bağlantılar dolu gelince performans düşüyor. bunun çaresi eager load yapmak gerektiği yerde de bağlantıları çekmek.
            // En iyi kullanım Eager Load ve gerekli yerde include.
            Personel personel = _uow._personelRep.FindDetail(Id);
            return View(personel);
        }
        
    }
    
}
