using KatmanliMimari.Dl;
using KatmanliMimari.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public class Unit : IUnit
    {
        MyContext _db;
        public IPersonnalRep _personelRep { get; private set; }


        public void Commit()
        {
            _db.SaveChanges();
        }
        public Unit(MyContext db, IPersonnalRep personelRep)
        {
            _db = db;
            _personelRep = personelRep;
        }
    }
}
