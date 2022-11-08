using _1_FirstEF.Context;
using _1_FirstEF.Data;
using Microsoft.AspNetCore.Mvc;

namespace _1_FirstEF.Controllers
{
    public class BaseController : Controller
    {
        public SatisContext _db;
        public BaseController(SatisContext db)
        {
            _db = db;
        }
        
    }
}
